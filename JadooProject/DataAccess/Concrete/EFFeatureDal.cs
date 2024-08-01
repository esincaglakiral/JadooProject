using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EFFeatureDal : Repository<Feature>, IFeatureDal
    {
        private readonly JadooContext _context;

        public EFFeatureDal(JadooContext context) : base(context)
        {
            _context = context;
        }

        public int GetFeatureCount()
        {
            return _context.Features.Count();
        }
    }
}
