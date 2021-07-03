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
    class RezervacijeViewModel:BaseViewModel
    {
        APIService _posudbaService = new APIService("Rezervacija");
        public ICommand InitCommand;

        public ObservableCollection<Rezervacija> rezervacije { get; set; } = new ObservableCollection<Rezervacija>();
        private Rezervacija _odabranaRezervacija;
        public Rezervacija OdabranaRezervacija
        {
            get => _odabranaRezervacija;
            set
            {
                SetProperty(ref _odabranaRezervacija, value);
                OnRezervacijaSelected(value);
            }
        }
        public Command<Rezervacija> RezervacijaTapped { get; }


        public RezervacijeViewModel()
        {
            InitCommand = new Command(async () => await Init());
            RezervacijaTapped = new Command<Rezervacija>(OnRezervacijaSelected);
        }
        public async Task Init()
        {
            rezervacije.Clear();
            RezervacijaSearchRequest search = new RezervacijaSearchRequest
            {
                ClanId = APIService.ID,
            };
            List<Rezervacija> lista = await _posudbaService.Get<Rezervacija>(search);
            foreach (Rezervacija r in lista)
            {
                rezervacije.Add(r);
            }
        }
        async void OnRezervacijaSelected(Rezervacija rezervacija)
        {
            if (rezervacija == null)
                return;

            await Shell.Current.GoToAsync($"{nameof(RezervacijaDetaljiPage)}?{nameof(RezervacijaDetaljiViewModel.RezervacijaId)}={rezervacija.Id}");
        }
    }
}
