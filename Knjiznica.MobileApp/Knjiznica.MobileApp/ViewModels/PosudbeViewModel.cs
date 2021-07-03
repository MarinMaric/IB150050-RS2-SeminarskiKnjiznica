using Knjiznica.MobileApp.Services;
using Knjiznica.Model;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Knjiznica.MobileApp.ViewModels
{
    public class PosudbeViewModel:BaseViewModel
    {
        APIService _posudbaService = new APIService("Posudba");
        public ICommand InitCommand;

        public ObservableCollection<Posudba> posudbe { get; set; } = new ObservableCollection<Posudba>();

        public PosudbeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public async Task Init()
        {
            PosudbaSearchRequest search = new PosudbaSearchRequest
            {
                ClanId = APIService.ID
            };
            List<Posudba> listaPosudbi = await _posudbaService.Get<Posudba>(search);
            foreach(Posudba p in listaPosudbi)
            {
                posudbe.Add(p);
            }
        }
    }
}
