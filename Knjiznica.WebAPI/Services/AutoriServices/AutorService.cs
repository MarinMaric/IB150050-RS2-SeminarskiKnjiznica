using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Knjiznica.Database;
using Knjiznica.Model.Requests;
using Knjiznica.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Knjiznica.WebAPI.Services
{
    public class AutorService : IAutorService
    {
        knjiznicaContext _db;
        IMapper _mapper;
        public AutorService(knjiznicaContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public List<Autor> Get(AutorSearchRequest search=null)
        {
            if (search==null || string.IsNullOrEmpty(search.ImePrezime))
                return _db.Autori.Where(x=>x.Deleted==0).ToList();
            return _db.Autori.Where(x => x.ImePrezime.Contains(search.ImePrezime)).ToList();
        }
        public Model.Autor Get(int id)
        {
            return _mapper.Map<Model.Autor>(_db.Autori.First(x => x.Id == id));
        }

        public Model.Autor Insert(AutorInsertRequest insert)
        {
            Autor autor = _mapper.Map<Autor>(insert);
            autor.ImePrezime = insert.Ime + " " + insert.Prezime;
            _db.Autori.Add(autor);
            _db.SaveChanges();
            return _mapper.Map<Model.Autor>(autor);
        }

        public Model.Autor Update(int id, AutorInsertRequest update)
        {
            Autor autor = _db.Autori.Where(x => x.Id == id).First();
            _mapper.Map(update, autor);
            _db.SaveChanges();
            return _mapper.Map<Model.Autor>(autor);
        }

        public void Delete(int id)
        {
            Autor autor = _db.Autori.Where(x => x.Id == id).First();
            _db.Autori.Remove(autor);
            _db.SaveChanges();
        }

        List<Model.Autor> IAutorService.Get(AutorSearchRequest search)
        {
            List<Autor> autori;
            if (search == null || string.IsNullOrEmpty(search.ImePrezime))
                autori = _db.Autori.Where(x => x.Deleted == 0).ToList();
            else autori = _db.Autori.Where(x => x.ImePrezime.Contains(search.ImePrezime)).ToList();
            return _mapper.Map<List<Model.Autor>>(autori);
        }
    }
}
