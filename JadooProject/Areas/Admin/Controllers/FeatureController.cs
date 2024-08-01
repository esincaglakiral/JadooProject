using AutoMapper;
using JadooProject.Features.CQRS.Commands.FeatureCommand;
using JadooProject.Features.CQRS.Handlers.FeatureHandlers;
using JadooProject.Features.CQRS.Queries.FeatureQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class FeatureController : Controller
    {
        private readonly IMapper _mapper;
        private readonly GetFeatureQueryHandler _getFeatureQueryHandler;
        private readonly GetFeatureByIdQueryHandler _getFeatureByIdQueryHandler;
        private readonly CreateFeatureCommandHandler _createFeatureCommandHandler;
        private readonly UpdateFeatureCommandHandler _updateFeatureCommandHandler;
        private readonly RemoveFeatureCommandHandler _removeFeatureCommandHandler;

        public FeatureController(IMapper mapper, GetFeatureQueryHandler getFeatureQueryHandler, GetFeatureByIdQueryHandler getFeatureByIdQueryHandler, CreateFeatureCommandHandler createFeatureCommandHandler, UpdateFeatureCommandHandler updateFeatureCommandHandler, RemoveFeatureCommandHandler removeFeatureCommandHandler)
        {
            _mapper = mapper;
            _getFeatureQueryHandler = getFeatureQueryHandler;
            _getFeatureByIdQueryHandler = getFeatureByIdQueryHandler;
            _createFeatureCommandHandler = createFeatureCommandHandler;
            _updateFeatureCommandHandler = updateFeatureCommandHandler;
            _removeFeatureCommandHandler = removeFeatureCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getFeatureQueryHandler.Handle();
            return View(values);
        }


        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureCommand command)
        {
            _createFeatureCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }



        public IActionResult DeleteFeature(int id)
        {
            _removeFeatureCommandHandler.Handle(new RemoveFeatureCommand(id));
            return RedirectToAction("Index");
        }




        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var values = _getFeatureByIdQueryHandler.Handle(new GetFeatureByIdQuery(id));
            var mappedValues = _mapper.Map<UpdateFeatureCommand>(values);
            return View(mappedValues);
        }



        [HttpPost]
        public IActionResult UpdateFeature(UpdateFeatureCommand command)
        {  
            _updateFeatureCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
