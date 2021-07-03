using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Database
{
    public class TipKorisnika
    {
           public int Id { get; set; }
           public int Naziv { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
