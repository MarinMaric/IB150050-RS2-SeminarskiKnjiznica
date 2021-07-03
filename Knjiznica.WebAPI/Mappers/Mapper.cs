using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knjiznica.WebAPI;
using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Knjiznica.WebAPI.Database;

namespace Knjiznica.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Knjiga, Model.Knjiga>().ForMember(dest => dest.Autor, options => options.MapFrom(src => src.Autor.ImePrezime)).ReverseMap();
            CreateMap<Knjiga, KnjigaInsertRequest>().ReverseMap();

            CreateMap<Autor, AutorInsertRequest>().ReverseMap();
            CreateMap<Autor, Model.Autor>();

            CreateMap<Kategorija, Model.Kategorija>();

            CreateMap<Clan, Model.Clan>().ForMember(dest => dest.BrojUpozorenja, options => options.MapFrom(src => src.Upozorenja.Count)).
                ForMember(dest => dest.BrojPosudbi, options => options.MapFrom(src => src.Posudbe.Count)).ReverseMap();
            CreateMap<Clan, ClanInsertRequest>().ReverseMap();

            CreateMap<Kopija, Model.Kopija>().
                ForMember(dest => dest.PosljednjiVlasnik, options => options.MapFrom(src => src.TrenutniVlasnik));
            CreateMap<Kopija, KopijaInsertRequest>().ReverseMap();

            CreateMap<Stanje, Model.Stanje>().ForMember(dest => dest.Vlasnik, options => options.MapFrom(src => src.Vlasnik.ImePrezime));
            CreateMap<Stanje, StanjeInsertRequest>().ReverseMap();

            CreateMap<Knjiznicar, Model.Korisnik>();
            CreateMap<Clan, Model.Korisnik>();

            CreateMap<WishlistStavka, Model.WishlistStavka>().ForMember(dest => dest.Slika, options => options.MapFrom(src => src.Knjiga.Slika))
                .ForMember(dest => dest.DostupnoKopija, options => options.MapFrom(src => src.Knjiga.BrojDostupnihKopija))
                .ForMember(dest => dest.Naslov, options => options.MapFrom(src => src.Knjiga.Naslov))
                .ForMember(dest => dest.DobavljenaKnjiga, options => options.MapFrom(src => src.Knjiga));
            CreateMap<WishlistStavka, WishlistStavkaInsertRequest>().ReverseMap();

            CreateMap<Wishlist, Model.Wishlist>();
            CreateMap<Wishlist, WishlistInsertRequest>().ReverseMap();

            CreateMap<Rezervacija, Model.Rezervacija>().
                ForMember(dest => dest.ImePrezime, options => options.MapFrom(src => src.Clan.ImePrezime)).
                ForMember(dest => dest.Naslov, options => options.MapFrom(src => src.Knjiga.Naslov)).
                ForMember(dest => dest.Status, options => options.MapFrom(src => src.Status.Status)).
                ForMember(dest => dest.Slika, options => options.MapFrom(src => src.Knjiga.Slika));
            CreateMap<Rezervacija, RezervacijaInsertRequest>().ReverseMap();

            CreateMap<Recenzija, Model.Recenzija>()
                .ForMember(dest => dest.Clan, options => options.MapFrom(src => src.Clan.ImePrezime))
                .ForMember(dest => dest.KnjigaNaslov, options => options.MapFrom(src => src.Knjiga.Naslov));
            CreateMap<Recenzija, RecenzijaInsertRequest>().ReverseMap();

            CreateMap<Kazna, Model.Kazna>().ForMember(dest => dest.ClanId, options => options.MapFrom(src => src.Posudba.ClanId))
                .ForMember(dest => dest.ClanIme, options => options.MapFrom(src => src.Posudba.Clan.ImePrezime))
                .ForMember(dest => dest.KnjiznicarIme, options => options.MapFrom(src => src.Propisao.ImePrezime));
            CreateMap<Kazna, KaznaInsertRequest>().ReverseMap();

            CreateMap<Upozorenje, Model.Upozorenje>().ForMember(dest => dest.KnjiznicarIme, options => options.MapFrom(src => src.Knjiznicar.ImePrezime));
            CreateMap<Upozorenje, UpozorenjeInsertRequest>().ReverseMap();

            CreateMap<UplataClanarine, Model.UplataClanarine>().ForMember(dest => dest.ClanIme, options => options.MapFrom(src => src.Clan.ImePrezime));
            CreateMap<UplataClanarine, UplataInsertRequest>().ReverseMap();

            CreateMap<Posudba, Model.Posudba>().ForMember(dest => dest.ClanIme, options => options.MapFrom(src => src.Clan.ImePrezime))
                .ForMember(dest => dest.BrojKopije, options => options.MapFrom(src => src.Kopija.BrojKopije))
                .ForMember(dest => dest.Naslov, options => options.MapFrom(src => src.Kopija.Knjiga.Naslov))
                .ForMember(dest => dest.Slika, options => options.MapFrom(src => src.Kopija.Knjiga.Slika));
            CreateMap<Posudba, PosudbaInsertRequest>().ReverseMap();

            CreateMap<Knjiznicar, Model.Knjiznicar>();
            CreateMap<Knjiznicar, KnjiznicarInsertRequest>().ReverseMap();
        }
    }
}
