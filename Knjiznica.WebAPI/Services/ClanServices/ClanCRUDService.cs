using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public class ClanCRUDService:CRUDService<Clan, Model.Clan, ClanInsertRequest>, IClanCRUDService
    {
        public ClanCRUDService(knjiznicaContext db, IMapper mapper):base(db, mapper)
        {
        }
        public override Model.Clan Insert(ClanInsertRequest insert)
        {
            if (_db.Clanovi.Any(x => x.Email == insert.Email)){
                throw new Exception("Email je već u uporabi");
            }
            Clan clan = _mapper.Map<Clan>(insert);
            clan.PasswordSalt = GenerateSalt();
            clan.PasswordHash = GenerateHash(clan.PasswordSalt, insert.Password);
            _db.Clanovi.Add(clan);
            _db.SaveChanges();
            return _mapper.Map<Model.Clan>(clan);
        }

        public override Model.Clan Update(int id, ClanInsertRequest update)
        {
            Clan clan = _db.Clanovi.Find(id);
            clan.Status = update.Status;
            _db.SaveChanges();
            return _mapper.Map<Model.Clan>(clan);
        }
        public override void Delete(int id)
        {
            Clan entity = _db.Clanovi.Find(id);
            entity.Deleted = 1;
            _db.SaveChanges();
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
    }
}
