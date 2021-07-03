using Knjiznica.MobileApp.Services;
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
    public class SankcijeViewModel : BaseViewModel
    {
        APIService _upozorenjaService = new APIService("Upozorenje");
        APIService _kazneService = new APIService("Kazna");
        public ObservableCollection<Upozorenje> upozorenja { get; set; } = new ObservableCollection<Upozorenje>();
        public ObservableCollection<Kazna> kazne { get; set; } = new ObservableCollection<Kazna>();
        public ICommand InitCommand;
        public Command UpozorenjaCommand { get; set; }
        public Command KazneCommand { get; set; }
        public Command UpozorenjeTapped { get; set; }

        bool _upozorenjaVisible;
        public bool UpozorenjaVisible
        {
            get { return _upozorenjaVisible; }
            set { SetProperty(ref _upozorenjaVisible, value);}
        }
        bool _kazneVisible;
        public bool KazneVisible
        {
            get { return _kazneVisible; }
            set { SetProperty(ref _kazneVisible, value); }
        }

        public SankcijeViewModel()
        {
            InitCommand = new Command(async () => await Init());
            UpozorenjaCommand = new Command(Upozorenja);
            KazneCommand = new Command(Kazne);
            UpozorenjeTapped= new Command<Upozorenje>(SelectUpozorenje);
        }

        public async Task Init()
        {
            UpozorenjeSearchRequest upozorenjeSearch = new UpozorenjeSearchRequest { ClanId = APIService.ID };

            var listUpozorenja = await _upozorenjaService.Get<Upozorenje>(upozorenjeSearch);
            upozorenja.Clear();
            foreach (Upozorenje u in listUpozorenja)
            {
                upozorenja.Add(u);
            }

            KaznaSearchRequest kazneSearch = new KaznaSearchRequest { ClanId = APIService.ID };

            var listKazne = await _kazneService.Get<Kazna>(kazneSearch);
            kazne.Clear();
            foreach (Kazna k in listKazne)
            {
                kazne.Add(k);
            }
        }
        public async void Upozorenja(object obj)
        {
            if (!UpozorenjaVisible)
            {
                UpozorenjaVisible = true;
                KazneVisible = false;
            }
        }
        public void Kazne()
        {
            if (!KazneVisible)
            {
                KazneVisible = true;
                UpozorenjaVisible = false;
            }
        }
        public async void SelectUpozorenje(Upozorenje upozorenje)
        {
            await Application.Current.MainPage.DisplayAlert("Opis", upozorenje.Opis, "OK");
        }
    }
}
