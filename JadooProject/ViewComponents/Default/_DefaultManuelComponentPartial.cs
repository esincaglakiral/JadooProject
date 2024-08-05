using JadooProject.Features.CQRS.Handlers.ManuelHandlers;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.ViewComponents.Default
{
    public class _DefaultManuelComponentPartial : ViewComponent
    {
        private readonly GetManuelQueryHandler _manuelQueryHandler;

        public _DefaultManuelComponentPartial(GetManuelQueryHandler manuelQueryHandler)
        {
            _manuelQueryHandler = manuelQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            var value = _manuelQueryHandler.Handle();
            return View(value);
        }
    }
}
