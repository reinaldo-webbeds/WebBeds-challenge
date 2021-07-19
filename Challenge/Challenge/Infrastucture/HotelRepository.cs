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

        private string _url = "https://webbedsdevtest.azurewebsites.net/api/findBargain?destinationId=279&nights=3&code=aWH1EX7ladA8C/oWJX5nVLoEa4XKz2a64yaWVvzioNYcEo8Le8caJw==";
        private HttpClient _http;
        public HotelRepository()
        {
            // TODO: usar httpclient factory
            _http = new HttpClient();
        }

        // TODO: delete after 
        //public HotelRepository()
        //{

        //}

        public async Task<List<Record>> GetHotels()
        {
            try
            {
                var response = await _http.GetStringAsync(_url);
                return JsonConvert.DeserializeObject<List<Record>>(response);
            }
            catch (Exception e)
            {
                //Tratar error por si la llamada no funciona
                return null;
            }
        }

    }
}
