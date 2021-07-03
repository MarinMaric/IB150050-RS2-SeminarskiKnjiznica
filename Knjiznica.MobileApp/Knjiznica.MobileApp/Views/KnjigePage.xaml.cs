using Knjiznica.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Knjiznica.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KnjigePage : ContentPage
    {
        KnjigeViewModel knjige = null;

        public KnjigePage()
        {
            InitializeComponent();
            BindingContext = knjige = new KnjigeViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await knjige.Init();
            knjige.OnAppearing();

        }
    }
}