using System;

namespace Knjiznica.Model
{
    public class Knjiga
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public int BrojStranica { get; set; }
        public int Ocjena { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int BrojKopija { get; set; }
        public int BrojDostupnihKopija { get; set; }
        public int KategorijaId { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public int Izdanje { get; set; }
        public byte[] Slika { get; set; }
    }
}
