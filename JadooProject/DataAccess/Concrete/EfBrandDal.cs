using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EfBrandDal : Repository<Brand>, IBrandDal
    {
        private readonly JadooContext _context;

        public EfBrandDal(JadooContext context) : base(context)
        {
            _context = context;
        }

        public int GetBrandCount()
        {
            return _context.Brands.Count();
        }
    }
}
