using Knjiznica.MobileApp.Services;
using Knjiznica.MobileApp.Views;
using Knjiznica.Model;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Knjiznica.MobileApp.ViewModels
{
    class WishlistViewModel: BaseViewModel
    {
        APIService _stavkaService = new APIService("WishlistStavka");
        APIService _wishlistService = new APIService("Wishlist");
        public Command<Knjiga> KnjigaTapped { get; }
        public ICommand InitCommand;

        private Knjiga _odabranaKnjiga;
        public ObservableCollection<Knjiga> knjige { get; set; } = new ObservableCollection<Knjiga>();

        string _naziv;
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }

        public WishlistViewModel()
        {
            InitCommand = new Command(async () => await Init());
            KnjigaTapped = new Command<Knjiga>(OnKnjigaSelected);
        }
        public async Task Init()
        {
            if (APIService.wishlistID == 0)
            {
                int wishlistId = 0;
                WishlistSearchRequest listaSearch = new WishlistSearchRequest
                {
                    ClanId = APIService.ID
                };
                List<Wishlist> listazelja = await _wishlistService.Get<Wishlist>(listaSearch);
                if (listazelja.Count > 0)
                {
                    wishlistId = listazelja.First().Id;
                }

                APIService.wishlistID = wishlistId;
            }
            WishlistStavkaSearchRequest search = new WishlistStavkaSearchRequest
            {
                WishlistId = APIService.wishlistID
            };

            var list = await _stavkaService.Get<WishlistStavka>(search);
            knjige.Clear();
            foreach (WishlistStavka s in list)
            {
                knjige.Add(s.DobavljenaKnjiga);
            }
        }
        public void OnAppearing()
        {
            IsBusy = true;
            OdabranaKnjiga = null;
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
