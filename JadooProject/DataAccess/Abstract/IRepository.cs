namespace JadooProject.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetList();
        T GetById(int id);
        void Delete(int id);
        void Update(T entity);
        void Create(T entity);
    }
}
