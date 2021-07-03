using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class Kategorija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Deleted { get; set; }
    }
}
