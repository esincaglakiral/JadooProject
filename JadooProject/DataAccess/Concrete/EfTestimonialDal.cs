using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.DataAccess.Repositories;

namespace JadooProject.DataAccess.Concrete
{
    public class EfTestimonialDal : Repository<Testimonial>, ITestimonialDal
    {
        private readonly JadooContext _context;

        public EfTestimonialDal(JadooContext context) : base(context)
        {
            _context = context;
        }

        public int GetTestimonailCount()
        {
            return _context.Testimonials.Count();
        }

        public List<Testimonial> GetDashboardTestimonails()
        {
            return _context.Testimonials.Take(6).ToList();
        }
    }
}
