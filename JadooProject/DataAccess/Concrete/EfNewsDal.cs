using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EfNewsDal : Repository<News>, INewsDal
    {
        private readonly JadooContext _context;

        public EfNewsDal(JadooContext context) : base(context)
        {
            _context = context;
        }

        public int GetNewsCount()
        {
            return _context.News.Count();
        }
    }
}
