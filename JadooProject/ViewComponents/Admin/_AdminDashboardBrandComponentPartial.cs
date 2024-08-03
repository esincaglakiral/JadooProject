using JadooProject.Features.CQRS.Handlers;
using JadooProject.Features.CQRS.Handlers.BrandHandlers;
using JadooProject.Features.Mediator.Handlers.TestimonialHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Admin
{
    public class _AdminDashboardBrandComponentPartial : ViewComponent
    {
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly GetDashboardQueryHandler _getDashboardQueryHandler;

        public _AdminDashboardBrandComponentPartial(GetBrandQueryHandler getBrandQueryHandler, GetDashboardQueryHandler getDashboardQueryHandler)
        {
            _getBrandQueryHandler = getBrandQueryHandler;
            _getDashboardQueryHandler = getDashboardQueryHandler;
        }


        public IViewComponentResult Invoke()
        {
            var brand = _getDashboardQueryHandler.Handle();
            ViewBag.BrandCount = brand.BrandCount;
            var value = _getBrandQueryHandler.Handle();
            return View(value);
        }
    }
}
