using PruebaApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Challenge.Infrastucture
{
    public interface IHotelRepository
    {
        Task<List<Record>> GetHotels();
    }
}