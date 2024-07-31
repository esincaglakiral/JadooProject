using MediatR;

namespace JadooProject.Features.Mediator.Commands.ServiceCommands
{
    public class CreateServiceCommand : IRequest  // herhangi bir response döndürmeyeceği için dönüş tipi belirtmiyoruz
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
