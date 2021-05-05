using FakeXiecheng.DataBase;
using FakeXiecheng.Moldes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.Services
{
    public class TouristRouteRespository : ITouristRouteRepository
    {
        private readonly AppDbContext context;
        public TouristRouteRespository(AppDbContext _context)
        {
            context = _context;
        }
        public TouristRoute GetTouristRoute(Guid touristrouteId)
        {
            return context.TouristRoutes.FirstOrDefault(c => c.Id == touristrouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return context.TouristRoutes;
        }
    }
}
