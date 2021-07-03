using Acr.UserDialogs;
using Knjiznica.MobileApp.Models;
using Knjiznica.MobileApp.Services;
using Knjiznica.Model;
using Knjiznica.Model.Requests;
using Prism.Commands;
using Prism.Mvvm;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Knjiznica.MobileApp.ViewModels
{
    public class PaymentGatewayPageViewModel : BindableBase
    {
        APIService apiService = new APIService("Clan");
        APIService uplateService = new APIService("Uplata");
        Clan clan;
        #region Variable

        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;
        private string StripeSecretApiKey= "sk_test_51J4hUjEGfZE811roQEDe2emvwB7dILV0UDT7DYCFancNjPCMaDDAiTzXFFpA6gD6g3lkQu5bjwYmBHMvq7bPk8ar00SCOBTBaR";
        #endregion Variable

        #region Public Property
        private string StripeTestApiKey = "pk_test_51J4hUjEGfZE811roXknrLQLFOJqQon6bbHLrYwMuvPoVlwQQfNVs3TLZNxhcu4toZsb1HyXyjZPwfs614Xr6e7E600Pu1PKwde";
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        #endregion Public Property

        #region Constructor

        public PaymentGatewayPageViewModel()
        {
            CreditCardModel = new CreditCardModel();
            Title = "Card Details";
            clan = apiService.GetById<Clan>(APIService.ID);
        }

        #endregion Constructor

        #region Command

        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {
            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Payment processing..");
                await Task.Run(async () =>
                {

                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token :" + Token);
                    if (Token != null)
                    {
                        IsTransectionSuccess = MakePayment(Token);
                        UplataInsertRequest insertUplata = new UplataInsertRequest { ClanId = APIService.ID, DatumUplacivanja = DateTime.Now, Iznos = 10, Opis = "Uplata članarine" };
                        await uplateService.Insert<Model.UplataClanarine>(insertUplata);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Bad card credentials", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("Payment Gatway" + ex.Message);
            }
            finally
            {
                if (IsTransectionSuccess)
                {
                    Console.Write("Payment Gateway" + "Payment Successful ");

                    UserDialogs.Instance.HideLoading();
                }
                else
                {

                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                    Console.Write("Payment Gateway" + "Payment Failure ");
                }
            }

        });

        #endregion Command

        #region Method

        private string CreateToken()
        {
            try
            {
                StripeConfiguration.ApiKey=StripeTestApiKey;
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = clan.ImePrezime,
                        AddressLine1 = "",
                        AddressLine2 = "",
                        AddressCity = "",
                        AddressZip = "",
                        AddressState = "",
                        AddressCountry = "",
                        Currency = "eur",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool MakePayment(string token)
        {
            try
            {
                StripeConfiguration.ApiKey = StripeSecretApiKey;
                var options = new ChargeCreateOptions
                {
                    Amount = (long)float.Parse("1000"),
                    Currency = "eur",
                    Description = "Uplata clanarine",
                    Source = stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = clan.Email,
                };

                if (clan.Email == "mobile")
                {
                    options.ReceiptEmail = "mobile@gmail.com";
                }

                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Payment Gatway (CreateCharge)" + ex.Message);
                throw ex;
            }
        }

        private bool ValidateCard()
        {
            if (CreditCardModel.Number.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && CreditCardModel.Cvc.Length == 3)
            {
            }
            return true;
        }

        #endregion Method
    }
}
