using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultLatestDestinationComponentPartial : ViewComponent
    {
        private readonly GetLatestDestinationQueryHandler _getLatestDestinationQueryHandler;

        public _DefaultLatestDestinationComponentPartial(GetLatestDestinationQueryHandler getLatestDestinationQueryHandler)
        {
            _getLatestDestinationQueryHandler = getLatestDestinationQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var value = _getLatestDestinationQueryHandler.Handle();
            return View(value);
        }
    }
}
