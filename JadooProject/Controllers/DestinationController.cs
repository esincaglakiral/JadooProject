using JadooProject.Features.CQRS.Commands.DestinationCommand;
using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using JadooProject.Features.CQRS.Queries;
using JadooProject.Features.CQRS.Queries.DestinationQueries;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace JadooProject.Controllers
{
    public class DestinationController : Controller
    {
        private readonly GetDestinationQueryHandler _getDestinationQueryHandler;
        private readonly GetDestinationByIdQueryHandler _getDestinationByIdQueryHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;
        public DestinationController(GetDestinationQueryHandler getDestinationQueryHandler, GetDestinationByIdQueryHandler getDestinationByIdQueryHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            _getDestinationQueryHandler = getDestinationQueryHandler;
            _getDestinationByIdQueryHandler = getDestinationByIdQueryHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestinationCommandHandler = removeDestinationCommandHandler;
            _updateDestinationCommandHandler = updateDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getDestinationQueryHandler.Handle();
            return View(values);  // liste türünde GetDestinationQueryResult döncek
        }


        [HttpGet]
        public IActionResult UpdateDestination(int id) 
        {
            var value = _getDestinationByIdQueryHandler.Handle(new GetDestinationByIdQuery(id));
            var destination = new UpdateDestinationCommand
            {
                DestinationId = value.DestinationId,
                City = value.City,
                Duration = value.Duration,
                ImageUrl = value.ImageUrl,
                Price = value.Price,
            };
            return View(destination);
        }

        [HttpPost]
        public IActionResult UpdateDestination(UpdateDestinationCommand command)
        {
            _updateDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult CreateDestination() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult CreateDestination(CreateDestinationCommand command)
        {
           _createDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");   
        }


        public IActionResult DeleteDestination(int id)
        {
            _removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(id));
            return RedirectToAction("Index");
        }
    }
}
