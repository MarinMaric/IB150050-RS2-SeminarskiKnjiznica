using Knjiznica.MobileApp.Services;
using Knjiznica.Model;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Knjiznica.MobileApp.ViewModels
{
    [QueryProperty(nameof(RezervacijaId), nameof(RezervacijaId))]
    class RezervacijaDetaljiViewModel :BaseViewModel
    {
        APIService _rezervacijeService = new APIService("Rezervacija");

        public ObservableCollection<Rezervacija> preporuceneKnjige { get; set; } = new ObservableCollection<Rezervacija>();
        public Command OtkaziCommand { get; }

        private int _rezervacijaId;
        private string _Naslov;
        private string _Status;
        private DateTime _DatumRezervacije;
        private DateTime _DatumIsteka;
        private byte[] _Slika;
        private int _KnjigaId;

        public int Id { get; set; }

        #region properties 
        public string Naslov
        {
            get => _Naslov;
            set => SetProperty(ref _Naslov, value);
        }
        public DateTime DatumRezervacije
        {
            get => _DatumRezervacije;
            set => SetProperty(ref _DatumRezervacije, value);
        }
        public DateTime DatumIsteka
        {
            get => _DatumIsteka;
            set => SetProperty(ref _DatumIsteka, value);
        }
        public byte[] Slika
        {
            get => _Slika;
            set => SetProperty(ref _Slika, value);
        }
        public string Status
        {
            get => _Status;
            set => SetProperty(ref _Status, value);
        }
        public int KnjigaId
        {
            get => _KnjigaId;
            set => SetProperty(ref _KnjigaId, value);
        }
        bool _otkaziVisible;
        public bool OtkaziVisible {
            get { return _otkaziVisible; }
            set { SetProperty(ref _otkaziVisible, value); }
        }
        #endregion

        public int RezervacijaId
        {
            get
            {
                return _rezervacijaId;
            }
            set
            {
                _rezervacijaId = value;
                LoadItemId(value);
            }
        }

        public RezervacijaDetaljiViewModel()
        {
            OtkaziCommand = new Command(async () => await Otkazi());
        }

        public async void LoadItemId(int itemId)
        {
            try
            {
                var item = _rezervacijeService.GetById<Rezervacija>(itemId);
                Id = item.Id;
                Naslov = item.Naslov;
                DatumRezervacije = item.DatumRezervacije;
                DatumIsteka = item.DatumIsteka;
                Status = item.Status;
                Slika = item.Slika;
                KnjigaId = item.KnjigaId;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed to Load Item");
            }

            if (Status == "Aktivna")
                OtkaziVisible = true;
        }
   
        public async Task Otkazi()
        {
            RezervacijaInsertRequest rezervacijaUpdate = new RezervacijaInsertRequest
            {
                ClanId=APIService.ID,
                DatumIsteka=DatumIsteka,
                DatumRezervacije=DatumRezervacije,
                KnjigaId=KnjigaId,
                StatusId = 2
            };
            Status = "Prekinuta";
            await _rezervacijeService.Update<Rezervacija>(RezervacijaId,rezervacijaUpdate);
        }
    }
}
