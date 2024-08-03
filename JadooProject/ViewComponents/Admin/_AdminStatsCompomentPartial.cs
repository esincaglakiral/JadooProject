using JadooProject.Features.CQRS.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Admin
{
    public class _AdminStatsCompomentPartial : ViewComponent
    {
        private readonly GetDashboardQueryHandler _getDashboardQueryHandler;

        public _AdminStatsCompomentPartial(GetDashboardQueryHandler getDashboardQueryHandler)
        {
            _getDashboardQueryHandler = getDashboardQueryHandler;
        }


        public IViewComponentResult Invoke()
        {
            var value = _getDashboardQueryHandler.Handle();
            ViewBag.TestimonialCount = value.TestimonailCount; 
            ViewBag.ServiceCount = value.ServiceCount;
            ViewBag.BrandCount = value.BrandCount;
            ViewBag.FeatureCount = value.FeatureCount;
            ViewBag.NewsCount = value.NewsCount;
            ViewBag.DestinationCount = value.DestinationCount;
      
            return View();
        }
    }
}
