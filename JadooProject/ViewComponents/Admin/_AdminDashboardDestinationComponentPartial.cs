using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Admin
{
    public class _AdminDashboardDestinationComponentPartial : ViewComponent
    {
        private readonly GetDestinationDashboardQueryHandler _getDestinationDashboardQueryHandler;

        public _AdminDashboardDestinationComponentPartial(GetDestinationDashboardQueryHandler getDestinationDashboardQueryHandler)
        {
            _getDestinationDashboardQueryHandler = getDestinationDashboardQueryHandler;
        }


        public IViewComponentResult Invoke()
        {
            var value = _getDestinationDashboardQueryHandler.Handle();
            return View(value);
        }
    }
}
