using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class ClanReadService : ReadService<Clan, Model.Clan, ClanSearchRequest>, IClanReadService
    {
        public ClanReadService(knjiznicaContext db, IMapper mapper):base(db, mapper)
        {
        }

        public override List<Model.Clan> Get(ClanSearchRequest search=null)
        {
            var query = _db.Clanovi.Include(x=>x.Posudbe).Include(x=>x.Upozorenja).Where(x=>x.Deleted==0).AsQueryable();
            var test = query.ToList();
            if (search != null)
            {
                if (!string.IsNullOrEmpty(search.Email))
                {
                    query = query.Where(x => x.Email == search.Email);
                }

                if (!string.IsNullOrEmpty(search.ImePrezime))
                {
                    query = query.Where(x => x.ImePrezime.Contains(search.ImePrezime));
                }

                if (search.BrojIskaznice > 0)
                {
                    query = query.Where(x => x.BrojIskaznice==search.BrojIskaznice);
                }

                if (!string.IsNullOrEmpty(search.Status))
                {
                    query = query.Where(x => x.Status == search.Status);
                }

                if(search.UpozorenjaMax!=0 && search.UpozorenjaMin!=0)
                    query = query.Where(x => x.Upozorenja.Count >= search.UpozorenjaMin && x.Upozorenja.Count <= search.UpozorenjaMax);
                if(search.PosudbeMax>0)
                    query = query.Where(x => x.Posudbe.Count >= search.PosudbeMin && x.Posudbe.Count <= search.PosudbeMax);
            }

            List<Clan> list = query.ToList();
            return _mapper.Map<List<Model.Clan>>(list);
        }

        public async Task<Model.Clan> Login(string username, string password)
        {
            var entity =  _db.Clanovi.FirstOrDefault(x => x.Email == username);

            if (entity == null)
            {
                throw new UserException("Pogrešan username ili password");
            }

            var hash = GenerateHash(entity.PasswordSalt, password);

            if (hash != entity.PasswordHash)
            {
                throw new UserException("Pogrešan username ili password");
            }

            return _mapper.Map<Model.Clan>(entity);
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
