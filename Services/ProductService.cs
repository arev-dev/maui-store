using MauiStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
//using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace MauiStore.Services
{
    internal class ProductService : IProductService
    {
        const string URL = "https://api.escuelajs.co/api/v1/products";//?offset=0&limit=10

        public async Task<List<Product>> Get()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(URL);
            var content = await response.Content.ReadAsStringAsync();
            var producto = JsonSerializer.Deserialize<List<Product>>(content);

            return producto;
        }

    }

}
