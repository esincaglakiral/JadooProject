using JadooProject.Features.CQRS.Handlers.BrandHandlers;
using JadooProject.Features.CQRS.Handlers.FeatureHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultBrandComponentPartial : ViewComponent
    {
        private readonly GetBrandQueryHandler _getBrandQueryHandler;

        public _DefaultBrandComponentPartial(GetBrandQueryHandler getBrandQueryHandler)
        {
            _getBrandQueryHandler = getBrandQueryHandler;
        }


        public IViewComponentResult Invoke()
        {
            var value = _getBrandQueryHandler.Handle();
            return View(value);
        }
    }
}
