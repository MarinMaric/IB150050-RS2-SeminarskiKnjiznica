using Knjiznica.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knjiznica.WebAPI.Services
{
    public interface IKorisnikService
    {
        Task<Model.Korisnik> Login(string username, string password);
        List<Model.Knjiznicar> Get(KnjiznicarSearchRequest search);
        void Register(KnjiznicarInsertRequest insert);
    }
}
