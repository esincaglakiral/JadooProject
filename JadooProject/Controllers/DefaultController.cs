using JadooProject.Features.CQRS.Commands.NewsCommand;
using JadooProject.Features.Mediator.Queries.DestinationQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JadooProject.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMediator _mediator;

        public DefaultController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> EmailSubscription(CreateNewsCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DefaultDestinations()
        {
            var values = await _mediator.Send(new GetDefaultDestinationQuery());
            return View(values);
        }


        public async Task<IActionResult> GetDestinationDetails(int id)
        {
            var value = await _mediator.Send(new GetDestinationsDetailsQuery(id));
            return View(value);
        }
    }
}
