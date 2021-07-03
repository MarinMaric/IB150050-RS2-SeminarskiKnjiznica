using Knjiznica.MobileApp.Services;
using Knjiznica.MobileApp.Views;
using Knjiznica.Model;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Knjiznica.MobileApp.ViewModels
{
    public class KnjigeViewModel:BaseViewModel
    {
        APIService _knjigeService = new APIService("Knjige");
        APIService _kategorijeService = new APIService("Kategorija");
        public Command<Knjiga> KnjigaTapped { get; }
        public ICommand InitCommand;
        public Command PretragaCommand { get; }
        private Knjiga _odabranaKnjiga;
        public ObservableCollection<Knjiga> knjige { get; set; } = new ObservableCollection<Knjiga>();
        public ObservableCollection<Kategorija> kategorije { get; set; } = new ObservableCollection<Kategorija>();
        Kategorija _selectedKategorija=null;

        string _naziv;
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }

        public KnjigeViewModel()
        {
            InitCommand = new Command(async () => await Init());
            PretragaCommand = new Command(async () => await Pretraga());
            KnjigaTapped = new Command<Knjiga>(OnKnjigaSelected);
        }
        public async Task Init()
        {
            if (kategorije.Count == 0)
            {
                var listKategorije = await _kategorijeService.Get<Kategorija>(null);
                foreach (Kategorija k in listKategorije)
                {
                    kategorije.Add(k);
                }
                kategorije.Insert(0, null);
            }

            if (SelectedKategorija != null)
            {
                KnjigaSearchRequest search = new KnjigaSearchRequest
                {
                    KategorijaId = SelectedKategorija.Id
                };
                var list = await _knjigeService.Get<Knjiga>(search);
                knjige.Clear();
                foreach (Knjiga k in list)
                {
                    knjige.Add(k);
                }
            }
        }

        public async Task Pretraga()
        {
            KnjigaSearchRequest search = new KnjigaSearchRequest
            {
                Naslov=_naziv
            };
            if (SelectedKategorija != null)
            {
                search.KategorijaId = SelectedKategorija.Id;
            }
            var list = await _knjigeService.Get<Knjiga>(search);
            knjige.Clear();
            foreach (Knjiga k in list)
            {
                knjige.Add(k);
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            OdabranaKnjiga = null;
        }

        public Kategorija SelectedKategorija
        {
            get { return _selectedKategorija; }
            set
            {
                SetProperty(ref _selectedKategorija, value);
                InitCommand.Execute(null);
            }
        }
        public Knjiga OdabranaKnjiga
        {
            get => _odabranaKnjiga;
            set
            {
                SetProperty(ref _odabranaKnjiga, value);
                OnKnjigaSelected(value);
            }
        }

        async void OnKnjigaSelected(Knjiga knjiga)
        {
            if (knjiga == null)
                return;

            await Shell.Current.GoToAsync($"{nameof(KnjigaDetalji)}?{nameof(KnjigaDetaljiViewModel.KnjigaId)}={knjiga.Id}");
        }
    }
}
