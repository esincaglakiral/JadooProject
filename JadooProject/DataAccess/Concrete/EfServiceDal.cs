using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EfServiceDal : Repository<Service>, IServiceDal
    {
        private readonly JadooContext _context;

        public EfServiceDal(JadooContext context) : base(context)
        {
            _context = context;
        }

        public int GetServiceCount()
        {
            return _context.Services.Count();
        }
    }
}
