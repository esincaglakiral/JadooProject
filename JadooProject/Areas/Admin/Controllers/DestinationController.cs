using AutoMapper;
using JadooProject.Features.CQRS.Commands.BrandCommand;
using JadooProject.Features.CQRS.Commands.DestinationCommand;
using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using JadooProject.Features.CQRS.Queries.BrandQueries;
using JadooProject.Features.CQRS.Queries.DestinationQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class DestinationController : Controller
    {
        private readonly GetDestinationQueryHandler _getDestinationQueryHandler;
        private readonly GetDestinationByIdQueryHandler _getDestinationByIdQueryHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;
        private readonly IMapper _mapper;


        public DestinationController(GetDestinationQueryHandler getDestinationQueryHandler, GetDestinationByIdQueryHandler getDestinationByIdQueryHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler, IMapper mapper)
        {
            _getDestinationQueryHandler = getDestinationQueryHandler;
            _getDestinationByIdQueryHandler = getDestinationByIdQueryHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestinationCommandHandler = removeDestinationCommandHandler;
            _updateDestinationCommandHandler = updateDestinationCommandHandler;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var value = _getDestinationQueryHandler.Handle();
            return View(value);
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




        public IActionResult UpdateDestination(int id)
        {
            var value = _getDestinationByIdQueryHandler.Handle(new GetDestinationByIdQuery(id));

            //var destination = new UpdateDestinationCommand()
            //{
            //    City = value.City,
            //    DestinationId = value.DestinationId,
            //    Duration = value.Duration,
            //    ImageUrl = value.ImageUrl,
            //    Price = value.Price,
            //    Description = value.Description,

            //};
            //return View(destination);



            var mappedValue = _mapper.Map<UpdateDestinationCommand>(value);
            return View(mappedValue);
        }




        [HttpPost]
        public IActionResult UpdateDestination(UpdateDestinationCommand command)
        {
            _updateDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

    }
}
