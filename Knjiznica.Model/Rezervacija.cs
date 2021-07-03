using System;
using System.Collections.Generic;
using System.Text;

namespace Knjiznica.Model
{
    public class Rezervacija
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public byte[] Slika { get; set; }
        public string ImePrezime { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumIsteka { get; set; }
        public string Status { get; set; }
        public int Deleted { get; set; } //0 - false
        public int KnjigaId { get; set; }
    }
}
