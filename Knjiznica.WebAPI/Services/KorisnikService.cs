using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class KorisnikService:IKorisnikService
    {
        IMapper _mapper;
        knjiznicaContext _db;

        public KorisnikService(IMapper mapper, knjiznicaContext db)
        {
            _mapper = mapper;
            _db = db;
        }

        public async Task<Model.Korisnik> Login(string username, string password)
        {
            Knjiznicar testKnjiznicar=null;  
            Clan testClan=null; 

            if(_db.Knjinicari.Any(x => x.Email == username))
                testKnjiznicar= _db.Knjinicari.FirstOrDefault(x => x.Email == username);
            else if(_db.Clanovi.Any(x => x.Email == username))
                testClan = _db.Clanovi.FirstOrDefault(x => x.Email == username);

            if (testClan==null && testKnjiznicar == null)
            {
                throw new UserException("Pogrešan username ili password");
            }

            if (testKnjiznicar != null)
            {
                var hash = GenerateHash(testKnjiznicar.PasswordSalt, password);

                if (hash != testKnjiznicar.PasswordHash)
                {
                    throw new UserException("Pogrešan username ili password");
                }

                var knjiznicar = _mapper.Map<Model.Korisnik>(testKnjiznicar);
                knjiznicar.Role = "Admin";
                return knjiznicar;
            }
            else
            {
                var hash = GenerateHash(testClan.PasswordSalt, password);

                if (hash != testClan.PasswordHash)
                {
                    throw new UserException("Pogrešan username ili password");
                }

                var clan =  _mapper.Map<Model.Korisnik>(testClan);
                clan.Role = "Clan";
                return clan;
            }
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public void Register(KnjiznicarInsertRequest insert)
        {
            Knjiznicar knjiznicar = _mapper.Map<Knjiznicar>(insert);
            knjiznicar.DatumZaposljavanja = DateTime.Now;
            knjiznicar.PasswordSalt = GenerateSalt();
            knjiznicar.PasswordHash = GenerateHash(knjiznicar.PasswordSalt, insert.Password);
            _db.Knjinicari.Add(knjiznicar);
            _db.SaveChanges();
        }

        public List<Model.Knjiznicar> Get(KnjiznicarSearchRequest search)
        {
            var list= _db.Knjinicari.Where(x => x.Email == search.Email);
            return _mapper.Map<List<Model.Knjiznicar>>(list);
        }
    }
}
