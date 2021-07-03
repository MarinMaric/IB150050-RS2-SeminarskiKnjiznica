using Knjiznica.Model;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica.WinUI
{
    public partial class frmLogin : Form
    {
        APIService APIService = new APIService("Kopije");
        APIService _serviceKnjiznicari = new APIService("Knjiznicar");
        MainMenu mainMenu;

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.username = txtUsername.Text;
            APIService.password = txtPassword.Text;

            try
            {
                //Poziva metodu namjenjenu samo za administratore (knjiznicare) kako bi blokiralo pristup clanovima
                await APIService.Get<Model.Kopija>(null);

                KnjiznicarSearchRequest searchKnjiznicar = new KnjiznicarSearchRequest { Email = APIService.username };
                List<Knjiznicar> knjiznicar = await _serviceKnjiznicari.Get<Model.Knjiznicar>(searchKnjiznicar);
                APIService.ID = knjiznicar.FirstOrDefault().Id;

                if (mainMenu == null)
                {
                    mainMenu = new MainMenu();
                    mainMenu.FormClosed += (s, args) => { this.Show(); mainMenu = null; };
                }
                
                mainMenu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nemate pravo pristupa.");
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }
    }
}
