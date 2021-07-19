using PruebaApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Challenge.Services
{
    public interface IHotelService
    {
        Task<List<Record>> GetHotels(int nights, int destinationId);
    }
}