using JadooProject.DataAccess.Entities;

namespace JadooProject.DataAccess.Abstract
{
    public interface ITestimonialDal : IRepository<Testimonial>
    {
        List<Testimonial> GetDashboardTestimonails();
        int GetTestimonailCount();    
    }
}
