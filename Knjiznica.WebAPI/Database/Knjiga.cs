using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.Database
{
    public class Knjiga
    {
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public int BrojStranica { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
        public string ISBN { get; set; }
        public int BrojKopija { get; set; }
        public int BrojDostupnihKopija { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public int Izdanje { get; set; }
        public byte[] Slika { get; set; }
        public List<Recenzija> Recenzije { get; set; }
        public int Deleted { get; set; }
    }
}
