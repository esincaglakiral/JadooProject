using JadooProject.DataAccess.Entities;

namespace JadooProject.DataAccess.Abstract
{
    public interface INewsDal : IRepository<News>
    {
        int GetNewsCount();
    }
}
