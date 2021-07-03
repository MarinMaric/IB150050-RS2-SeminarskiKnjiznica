using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class Status
    {
        public string Value { get; set; }
        public string Naziv { get; set; }
        public int Deleted { get; set; } //0 - false
    }
}
