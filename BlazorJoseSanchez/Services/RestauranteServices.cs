using BlazorJoseSanchez.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorJoseSanchez.Services
{
    public class RestauranteServices : IRestauranteServices
    {

        private readonly HttpClient _httpClient1;
        public RestauranteServices(HttpClient httpClient) 
        {
            _httpClient1 = httpClient;
        }


        public async Task<IEnumerable<Restaurante>> GetAllRestaurantes()
        {
            return JsonConvert.DeserializeObject<IEnumerable<Restaurante>>(
            await _httpClient1.GetStringAsync($"Restaurante")
            );


        }

        public Task<IEnumerable<Restaurante>> GetIDRestaurantes(int id)
        {
            throw new NotImplementedException();
        }
    }
}
