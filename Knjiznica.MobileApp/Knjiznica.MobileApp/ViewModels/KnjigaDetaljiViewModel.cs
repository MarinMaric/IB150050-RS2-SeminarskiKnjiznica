using Knjiznica.MobileApp.Services;
using Knjiznica.MobileApp.Views;
using Knjiznica.Model;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Knjiznica.MobileApp.ViewModels
{
    [QueryProperty(nameof(KnjigaId), nameof(KnjigaId))]
    public class KnjigaDetaljiViewModel : BaseViewModel
    {
        APIService _knjigeService = new APIService("Knjige");
        APIService _recommendService = new APIService("Recommend");
        APIService _wishlistService = new APIService("Wishlist");
        APIService _stavkaService = new APIService("WishlistStavka");
        APIService _rezervacijeService = new APIService("Rezervacija");
        APIService _recenzijeService = new APIService("Recenzije");

        public ObservableCollection<Knjiga> preporuceneKnjige { get; set; } = new ObservableCollection<Knjiga>();
        public ICommand InitCommand;
        public Command<Knjiga> KnjigaTapped { get; }

        public Command RezervirajCommand { get; }
        public Command WishlistCommand { get; }
        public Command UndoWishlistCommand { get; }
        public Command OcjeniCommand { get; }

        private int _knjigaId;
        private string _Naslov;
        private string _Opis;
        private string _Autor;
        private string _ISBN;
        private int _BrojStranica;
        private int _BrojDostupnihKopija;
        private decimal _Ocjena;
        private byte[] _Slika;

        private int _ocjena;

        public DateTime Datum { get; set; }

        public int Id { get; set; }

        #region properties 
        public string Naslov
        {
            get => _Naslov;
            set => SetProperty(ref _Naslov, value);
        }
        public string Opis
        {
            get => _Opis;
            set => SetProperty(ref _Opis, value);
        }
        public string Autor
        {
            get => _Autor;
            set => SetProperty(ref _Autor, value);
        }
        public string ISBN
        {
            get => _ISBN;
            set => SetProperty(ref _ISBN, value);
        }
        public int BrojStranica
        {
            get => _BrojStranica;
            set => SetProperty(ref _BrojStranica, value);
        }
        public int BrojDostupnihKopija
        {
            get => _BrojDostupnihKopija;
            set => SetProperty(ref _BrojDostupnihKopija, value);
        }
        public byte[] Slika
        {
            get => _Slika;
            set => SetProperty(ref _Slika, value);
        }
        public decimal ProsjekOcjena
        {
            get => _Ocjena;
            set => SetProperty(ref _Ocjena, value);
        }
        #endregion

        public int KnjigaId
        {
            get
            {
                return _knjigaId;
            }
            set
            {
                _knjigaId = value;
                LoadItemId(value);
            }
        }
        public string Ocjena
        {
            get
            {
                return _ocjena.ToString();
            }
            set
            {
                if(int.TryParse(value, out int n))
                {
                    _ocjena = n;
                }
            }
        }
        bool _dodajVisible;
        public bool DodajVisible { 
            get { return _dodajVisible; }
            set { SetProperty(ref _dodajVisible, value); } 
        }
        bool _ukloniVisible;
        public bool UkloniVisible
        {
            get { return _ukloniVisible; }
            set { SetProperty(ref _ukloniVisible, value); }
        }

        public KnjigaDetaljiViewModel()
        {
            RezervirajCommand = new Command(async () => await Rezerviraj());
            WishlistCommand= new Command(async () => await Wishlist());
            UndoWishlistCommand= new Command(async () => await UndoWishlist());
            OcjeniCommand = new Command(async () => await Ocjeni());
            InitCommand = new Command(async () => await Init());
            KnjigaTapped = new Command<Knjiga>(OnKnjigaSelected);
        }

        public async void LoadItemId(int itemId)
        {
            try
            {
                var item = _knjigeService.GetById<Knjiga>(itemId);
                Id = item.Id;
                Naslov = item.Naslov;
                Opis = item.Opis;
                ISBN = item.ISBN;
                Autor = item.Autor;
                ProsjekOcjena = item.Ocjena;
                BrojDostupnihKopija = item.BrojDostupnihKopija;
                BrojStranica = item.BrojStranica;
                Slika = item.Slika;
                
                var stavkaCheck = await CheckWishlist();
                if (stavkaCheck != null)
                {
                    DodajVisible = false;
                    UkloniVisible = true;
                }else
                {
                    DodajVisible = true;
                    UkloniVisible = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

        public async Task Rezerviraj()
        {
            if (BrojDostupnihKopija == 0)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Nema slobodnih primjeraka.", "OK");
                return;
            }
            Datum = DateTime.Now;
            RezervacijaInsertRequest rezervacijaInsert = new RezervacijaInsertRequest
            {
                ClanId = APIService.ID,
                KnjigaId = _knjigaId,
                DatumRezervacije = Datum,
                DatumIsteka = Datum.AddDays(5),
                StatusId = 1
            };

            await _rezervacijeService.Insert<Rezervacija>(rezervacijaInsert);
            await Application.Current.MainPage.DisplayAlert("Obavjest", "Knjiga uspješno rezervirana.", "OK");
        }

        public async Task Wishlist()
        {
            int wishlistId = 0;
            WishlistSearchRequest search = new WishlistSearchRequest
            {
                ClanId = APIService.ID
            };
            List<Wishlist> list = await _wishlistService.Get<Wishlist>(search);
            if (list.Count > 0)
            {
                wishlistId = list.First().Id;
            }
            else
            {
                WishlistInsertRequest insertWishlist = new WishlistInsertRequest { ClanId = APIService.ID, Naziv = "Default wishlist" };
                Model.Wishlist wishLista = await _wishlistService.Insert<Wishlist>(insertWishlist);
                wishlistId = wishLista.Id;
            }
            APIService.wishlistID = wishlistId;
            WishlistStavkaInsertRequest stavkaInsert = new WishlistStavkaInsertRequest
            {
               KnjigaId=_knjigaId,
               WishlistId = wishlistId,
            };
            try
            {
                await _stavkaService.Insert<WishlistStavka>(stavkaInsert);
                await Application.Current.MainPage.DisplayAlert("Obavjest", "Knjiga dodana na wishlist", "OK");
                DodajVisible = false;
                UkloniVisible = true;
            }catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Dodavanje nije uspjelo", "OK");
            }
        }
        public async Task UndoWishlist()
        {
            WishlistStavka s = await CheckWishlist();

            _stavkaService.Delete<WishlistStavka>(s.Id);

            DodajVisible = true;
            UkloniVisible = false;
        }
        public async Task<Model.WishlistStavka> CheckWishlist()
        {
            WishlistStavkaSearchRequest search = new WishlistStavkaSearchRequest
            {
                WishlistId = APIService.wishlistID,
                KnjigaId = _knjigaId
            };
            var wishlistStavkas = await _stavkaService.Get<WishlistStavka>(search);
            if (wishlistStavkas.Count > 0)
            {
                WishlistStavka s = wishlistStavkas.First();
                return s;
            }
            else return null;
            
        }
        public async Task Ocjeni()
        {
            if(!int.TryParse(Ocjena, out int n))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Invalid ocjena", "OK");
            }else    if (_ocjena<1 || _ocjena > 5)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Unesite ocjenu od 1 do 5", "OK");
            }
            else
            {
                RecenzijaInsertRequest recenzijaInsertRequest = new RecenzijaInsertRequest
                {
                    ClanId = APIService.ID,
                    KnjigaId = _knjigaId,
                    Komentar = "",
                    Ocjena = _ocjena
                };
                await _recenzijeService.Insert<Recenzija>(recenzijaInsertRequest);
                await Application.Current.MainPage.DisplayAlert("Cestitamo", "Uspjesno ste ocjenili knjigu", "OK");
            }
        }

        public async Task Init()
        {

            var list =  _recommendService.Recommend<Knjiga>(KnjigaId);
            preporuceneKnjige.Clear();
            foreach (Knjiga k in list)
            {
                preporuceneKnjige.Add(k);
            }
        }
        private Knjiga _odabranaKnjiga;

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
