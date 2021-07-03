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
    public class UplateViewModel:BaseViewModel
    {
        APIService _uplateService = new APIService("Uplata");
        public ObservableCollection<UplataClanarine> uplate { get; set; } = new ObservableCollection<UplataClanarine>();
        public ICommand InitCommand;

        public UplateViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public async Task Init()
        {
            UplataSearchRequest searchRequest = new UplataSearchRequest { ClanId = APIService.ID };

            var list = await _uplateService.Get<UplataClanarine>(searchRequest);
            uplate.Clear();
            foreach (UplataClanarine u in list)
            {
                uplate.Add(u);
            }
        }
    }
}
