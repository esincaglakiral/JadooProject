using AutoMapper;
using JadooProject.Features.CQRS.Commands.BrandCommand;
using JadooProject.Features.CQRS.Handlers.BrandHandlers;
using JadooProject.Features.CQRS.Queries.BrandQueries;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class BrandController : Controller
    {
        private readonly IMapper _mapper;
        private readonly GetBrandQueryHandler _brandQueryHandler;
        private readonly GetBrandByIdQueryHandler _brandByIdQueryHandler;
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;
        private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;

        public BrandController(IMapper mapper, GetBrandQueryHandler brandQueryHandler, GetBrandByIdQueryHandler brandByIdQueryHandler, CreateBrandCommandHandler createBrandCommandHandler, UpdateBrandCommandHandler updateBrandCommandHandler, RemoveBrandCommandHandler removeBrandCommandHandler)
        {
            _mapper = mapper;
            _brandQueryHandler = brandQueryHandler;
            _brandByIdQueryHandler = brandByIdQueryHandler;
            _createBrandCommandHandler = createBrandCommandHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
            _removeBrandCommandHandler = removeBrandCommandHandler;
        }

        public IActionResult Index()
        {
            var value = _brandQueryHandler.Handle();
            return View(value);
        }



        [HttpGet]
        public IActionResult CreateBrand()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBrand(CreateBrandCommand command)
        {
            _createBrandCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }



        public IActionResult DeleteBrand(int id)
        {
            _removeBrandCommandHandler.Handle(new RemoveBrandCommand(id));
            return RedirectToAction("Index");
        }




        [HttpGet]
        public IActionResult UpdateBrand(int id)
        {
            var value = _brandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
            var mappedValue = _mapper.Map<UpdateBrandCommand>(value);
            return View(mappedValue);
        }

        [HttpPost]
        public IActionResult UpdateBrand(UpdateBrandCommand command)
        {
            _updateBrandCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

    }
}
