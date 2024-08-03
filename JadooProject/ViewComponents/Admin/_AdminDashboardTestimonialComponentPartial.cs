using JadooProject.Features.CQRS.Handlers;
using JadooProject.Features.Mediator.Handlers.TestimonialHandlers;
using JadooProject.Features.Mediator.Queries.TestimonialQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Admin
{
    public class _AdminDashboardTestimonialComponentPartial : ViewComponent
    {
        private readonly GetTestimonialForDashboardQueryHandler _getTestimonialForDashboradQueryHandler;
        private readonly GetDashboardQueryHandler _getDashboardQueryHandler;

        public _AdminDashboardTestimonialComponentPartial(GetTestimonialForDashboardQueryHandler getTestimonialForDashboradQueryHandler, GetDashboardQueryHandler getDashboardQueryHandler)
        {
            _getTestimonialForDashboradQueryHandler = getTestimonialForDashboradQueryHandler;
            _getDashboardQueryHandler = getDashboardQueryHandler;
        }
        public IViewComponentResult Invoke()
        {
            var testimonial = _getDashboardQueryHandler.Handle();
            ViewBag.TestimonialCount = testimonial.TestimonailCount;
            var request = new GetTestimonialDashboardQuery(); 
            var value = _getTestimonialForDashboradQueryHandler.Handle(request, CancellationToken.None).Result;
            return View(value);
        }

    }
}
