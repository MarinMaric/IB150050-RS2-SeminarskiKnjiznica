using Knjiznica.MobileApp.Services;
using Knjiznica.MobileApp.Views;
using Knjiznica.Model;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Knjiznica.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        APIService _clanService = new APIService("Clan");
        APIService _wishlistService = new APIService("Wishlist");
        #region properties
        string _username;
        public string Username{
            get{ return _username; }
            set { SetProperty(ref _username, value); }
        }
        string _password;
        public string Password 
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        string _email, _regPass, _passConfirm, _brojTelefona, _imePrezime; 
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        public string RegPassword
        {
            get { return _regPass; }
            set { SetProperty(ref _regPass, value); }
        }
        public string RegPassConfirm
        {
            get { return _passConfirm; }
            set { SetProperty(ref _passConfirm, value); }
        }
        public string BrojTelefona
        {
            get { return _brojTelefona; }
            set { SetProperty(ref _brojTelefona, value); }
        }
        public string ImePrezime
        {
            get { return _imePrezime; }
            set { SetProperty(ref _imePrezime, value); }
        }
        bool _registerVisible=false;
        public bool RegisterVisible
        {
            get { return _registerVisible; }
            set
            {
                SetProperty(ref _registerVisible, value);
            }
        }
        bool _loginVisible = true;
        public bool LoginVisible
        {
            get { return _loginVisible; }
            set
            {
                SetProperty(ref _loginVisible, value);
            }
        }
        #endregion

        public Command LoginCommand { get; }
        public Command RegisterCommand { get; set; }
        public Command RedirectCommand { get; set; }
        public Command BackLoginCommand { get; }
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            RegisterCommand = new Command(OnRegisterClicked);
            RedirectCommand = new Command(RevealForm);
            BackLoginCommand = new Command(BackLogin);
        }

      
        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            APIService.Username = Username;
            APIService.Password = Password;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste unjeli email ili sifru.", "OK");
            }
            else
            {
                try
                {
                    await _wishlistService.Get<Wishlist>(null);

                    ClanSearchRequest clanSearch = new ClanSearchRequest { Email = APIService.Username };
                    var lista = await _clanService.Get<Clan>(clanSearch);
                    APIService.ID = lista[0].Id;

                    Application.Current.MainPage = new AppShell();
                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Pogrešan email ili lozinka.", "OK");
                }
            }
        }
        private async void OnRegisterClicked(object obj)
        {
            
            if (!await Validate())
            {
                return;
            }

            try
            {
                ClanInsertRequest register = new ClanInsertRequest { Email = Email, Password = RegPassword, PasswordConfirm=RegPassConfirm, ImePrezime=_imePrezime, BrojTelefona="" };
                await _clanService.InsertNoAuth<Clan>(register);
                await Application.Current.MainPage.DisplayAlert("Obavjest", "Uspješno ste registrirani.", "OK");
                RegisterVisible = false;
                LoginVisible = true;
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Email je već u uporabi.", "OK");
            }
        }
        public async Task<bool> Validate()
        {
            try
            {
                MailAddress testMail = new MailAddress(Email);
            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Email je neispravan.", "OK");
                return false;
            }
            if (string.IsNullOrEmpty(ImePrezime))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Ime i prezime je obavezno", "OK");
                return false;
            }
            if (string.IsNullOrEmpty(RegPassword))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Lozinka je obavezna.", "OK");
                return false;
            }
            if (RegPassword.Length<6)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Lozinka mora imati barem 6 znakova", "OK");
                return false;
            }
            if (RegPassword!=RegPassConfirm)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Lozinke se ne podudaraju", "OK");
                return false;
            }
            
            return true;
        }
        void RevealForm()
        {
            RegisterVisible = !RegisterVisible;
            LoginVisible = !LoginVisible;
        }
        void BackLogin()
        {
            LoginVisible = true;
            RegisterVisible = false;
        }
    }
}
