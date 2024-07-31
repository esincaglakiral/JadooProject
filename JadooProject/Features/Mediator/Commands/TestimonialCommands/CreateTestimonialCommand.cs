using MediatR;

namespace JadooProject.Features.Mediator.Commands.TestimonialCommands
{
    public class CreateTestimonialCommand : IRequest
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Country { get; set; }
        public string ImageUrl { get; set; }
    }
}
