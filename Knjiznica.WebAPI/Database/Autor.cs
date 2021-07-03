using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class Autor
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public int Deleted { get; set; }
    }
}
