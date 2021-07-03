using Knjiznica.MobileApp.ViewModels;
using Knjiznica.MobileApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Knjiznica.MobileApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(KnjigaDetalji), typeof(KnjigaDetalji));
            Routing.RegisterRoute(nameof(RezervacijaDetaljiPage), typeof(RezervacijaDetaljiPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
