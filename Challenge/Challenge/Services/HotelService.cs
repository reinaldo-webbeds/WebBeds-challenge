using Challenge.Infrastucture;
using PruebaApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        private const int Nights = 3;


        public HotelService(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public async Task<List<Record>> GetHotels()
        {
            // TODO: pendiente de pasar los parámetros para la inyección de dependencias
            var hoteles = await _hotelRepository.GetHotels();

            foreach (var hotel in hoteles)
            {
                for (int i = 0; i < hotel.rates.Length; i++)
                {
                    if (hotel.rates[i].rateTypeBool)
                    {         //rateTypeBool es true cuando la reserva es por noche
                        hotel.rates[i].value = Nights * hotel.rates[i].value;
                    }
                }
            }
            return hoteles;


        }

    }
}
