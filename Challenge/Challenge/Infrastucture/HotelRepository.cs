using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using PruebaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Challenge.Infrastucture
{
    public class HotelRepository : IHotelRepository
    {

        private string _url;
        private static IHttpClientFactory _clientFactory;
        private readonly IConfiguration _configuration;
        public HotelRepository(IHttpClientFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
        }

        public async Task<List<Record>> GetHotels(int nights, int destinationId)
        {
            var client = _clientFactory.CreateClient();
            var baseUrl = _configuration["URLCheapAwesomeApi"];
            var token = _configuration["Token"];

            if (String.IsNullOrEmpty(baseUrl) || String.IsNullOrEmpty(token))
            {
                // raise exception
            }

            _url = $"{baseUrl}?destinationId={destinationId}&nights={nights}&code={token}";

            var response = await client.GetAsync(_url);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Record>>(await response.Content.ReadAsStringAsync());
            }

            return new List<Record>();

        }

    }

}
