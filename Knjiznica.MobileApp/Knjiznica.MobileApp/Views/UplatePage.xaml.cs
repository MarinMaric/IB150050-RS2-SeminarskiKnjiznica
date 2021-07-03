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
    public partial class UplatePage : ContentPage
    {
        UplateViewModel viewModel = null;

        public UplatePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new UplateViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.Init();
        }
    }
}