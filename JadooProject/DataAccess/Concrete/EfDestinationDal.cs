using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EfDestinationDal : Repository<Destination>, IDestinationDal
    {
        private readonly JadooContext _context;

        public EfDestinationDal(JadooContext context) : base(context)
        {
            _context = context;
        }

        public int GetDestinationCount()
        {
            return _context.Destinations.Count();
        }

        public List<Destination> GetLast3Destination()
        {
            return _context.Destinations.OrderByDescending(x => x.DestinationId).Take(3).ToList();
        }

        public List<Destination> GetLast6Destination()
        {
            return _context.Destinations.OrderByDescending(x => x.DestinationId).Take(6).ToList();
        }

        public Destination GetLastDestination()
        {
            return _context.Destinations.OrderByDescending(x => x.DestinationId).Take(1).FirstOrDefault();
        }
    }
}
