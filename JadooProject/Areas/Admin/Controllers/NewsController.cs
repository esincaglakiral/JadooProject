using AutoMapper;
using JadooProject.Features.CQRS.Commands.DestinationCommand;
using JadooProject.Features.CQRS.Commands.NewsCommand;
using JadooProject.Features.CQRS.Handlers.DestinationHandlers;
using JadooProject.Features.CQRS.Handlers.NewsHandlers;
using JadooProject.Features.CQRS.Queries.NewsQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class NewsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly GetNewsQueryHandler _getNewsQueryHandler;
        private readonly GetNewsByIdQueryHandler _getNewsByIdQueryHandler;
        private readonly CreateNewsCommandHandler _createNewsCommandHandler;
        private readonly UpdateNewsCommandHandler _updateNewsCommandHandler;
        private readonly RemoveNewsCommandHandler _removeNewsCommandHandler;

        public NewsController(IMapper mapper, GetNewsQueryHandler getNewsQueryHandler, GetNewsByIdQueryHandler getNewsByIdQueryHandler, CreateNewsCommandHandler createNewsCommandHandler, UpdateNewsCommandHandler updateNewsCommandHandler, RemoveNewsCommandHandler removeNewsCommandHandler)
        {
            _mapper = mapper;
            _getNewsQueryHandler = getNewsQueryHandler;
            _getNewsByIdQueryHandler = getNewsByIdQueryHandler;
            _createNewsCommandHandler = createNewsCommandHandler;
            _updateNewsCommandHandler = updateNewsCommandHandler;
            _removeNewsCommandHandler = removeNewsCommandHandler;
        }

        public IActionResult Index()
        {
            var value = _getNewsQueryHandler.Handle();
            return View(value);
        }



        [HttpGet]
        public IActionResult CreateNews()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateNews(CreateNewsCommand command)
        {
            _createNewsCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }



        public IActionResult DeleteNews(int id)
        {
            _removeNewsCommandHandler.Handle(new RemoveNewsCommand(id));
            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult UpdateNews(int id)
        {
            var value = _getNewsByIdQueryHandler.Handle(new GetNewsByIdQuery(id));
            var mappedValue = _mapper.Map<UpdateNewsCommand>(value);
            return View(mappedValue);
        }



        [HttpPost]
        public IActionResult UpdateNews(UpdateNewsCommand command)
        {
            _updateNewsCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
