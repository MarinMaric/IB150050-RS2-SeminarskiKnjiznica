using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Database
{
    public class StatusRezervacije
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
