using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model.Requests
{
    public class ClanInsertRequest
    {
        public string ImePrezime { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public string Status { get; set; }
    }
}
