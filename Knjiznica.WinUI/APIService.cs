using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Knjiznica.Model;
using Knjiznica.Model.Requests;
using Flurl;
using Flurl.Http;

namespace Knjiznica.WinUI
{
    public class APIService
    {
        string _route;
        public static string username { get; set; }
        public static string password { get; set; }
        public static int ID { get; set; }
        public APIService(string route)
        {
            _route = route;
        }

        public async void GetForLogin<T>()
        {
            var url = $"{ Properties.Settings.Default.APIUrl }{_route}";

            await url.WithBasicAuth(username, password).GetJsonAsync<List<T>>();
        }

        public async Task<List<T>> Get<T>(object search=null)
        {
            var url = $"{ Properties.Settings.Default.APIUrl }{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return url.WithBasicAuth(username, password).GetJsonAsync<List<T>>().Result;
        }

        public T GetById<T>(int id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}{_route}/{id}";
            return url.WithBasicAuth(username, password).GetJsonAsync<T>().Result;
        }

        public async Task<T> Insert<T>(object insert)
        {
            var url = $"{Properties.Settings.Default.APIUrl}{_route}";
         

            return await url.WithBasicAuth(username, password).PostJsonAsync(insert).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id, object update)
        {
            var url = $"{Properties.Settings.Default.APIUrl}{_route}/{id}";

            return await url.WithBasicAuth(username, password).PutJsonAsync(update).ReceiveJson<T>();
        }

        public async void Delete<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}{_route}/{id}";
            await url.WithBasicAuth(username, password).DeleteAsync();
        }
    }
}
