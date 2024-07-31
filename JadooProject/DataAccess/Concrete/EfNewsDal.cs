using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EfNewsDal : Repository<News>, INewsDal
    {
        public EfNewsDal(JadooContext context) : base(context)
        {
        }

        public int GetNewsCount()
        {
            var context = new JadooContext();
            return context.News.Count();
        }
    }
}
