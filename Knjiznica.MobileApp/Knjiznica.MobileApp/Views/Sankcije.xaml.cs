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
    public partial class Sankcije : ContentPage
    {
        SankcijeViewModel sankcijeViewModel = null;
        public Sankcije()
        {
            InitializeComponent();
            BindingContext = sankcijeViewModel = new SankcijeViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await sankcijeViewModel.Init();
        }
    }
}