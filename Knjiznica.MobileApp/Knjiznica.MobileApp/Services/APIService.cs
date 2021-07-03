using Flurl.Http;
using Knjiznica.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Knjiznica.MobileApp.Services
{
    public class APIService
    {
        string _url;
        string _route;
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int ID { get; set; }
        public static int wishlistID { get; set; }

        public APIService(string route)
        {
            _route = route;
            _url = "http://localhost:59788/api/";
        }

        public async Task<List<T>> Get<T>(object search = null)
        {
            var url = $"{ _url }{_route}";
            
            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return url.WithBasicAuth(Username, Password).GetJsonAsync<List<T>>().Result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 403 ||ex.Call.Response.StatusCode==401)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                }

                throw;
            }
        }

        public T GetById<T>(int id)
        {
            var url = $"{_url}{_route}/{id}";
            return url.WithBasicAuth(Username, Password).GetJsonAsync<T>().Result;
        }

        public List<T> Recommend<T>(int id)
        {
            var url = $"{_url}{_route}/{id}";
            return url.GetJsonAsync<List<T>>().Result;
        }

        public async Task<T> InsertNoAuth<T>(object insert)
        {
            var url = $"{_url}{_route}";


            return await url.PostJsonAsync(insert).ReceiveJson<T>();
        }

        public async Task<T> Insert<T>(object insert)
        {
            var url = $"{_url}{_route}";


            return await url.WithBasicAuth(Username, Password).PostJsonAsync(insert).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id, object update)
        {
            var url = $"{_url}{_route}/{id}";

            try
            {
                if (update != null)
                {
                    url += "?";
                    url += await update.ToQueryString();
                }

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(update).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    //MessageBox.Show("Niste authentificirani");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                }

                throw;
            }

        }

        public async void Delete<T>(object id)
        {
            var url = $"{_url}{_route}/{id}";
            try
            {
                await url.WithBasicAuth(Username, Password).DeleteAsync();
            }
            catch(FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 403 || ex.Call.Response.StatusCode==401)
                {
                    //MessageBox.Show("Niste authentificirani");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                }
            }
        }
    }
}
