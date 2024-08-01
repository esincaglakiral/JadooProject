using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Commands.TestimonialCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.TestimonialHandlers
{
    public class RemoveTestimonialCommandHandler : IRequestHandler<RemoveTestimonialCommand>
    {
        private readonly JadooContext _context;

        public RemoveTestimonialCommandHandler(JadooContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveTestimonialCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Testimonials.FindAsync(request.Id);
            _context.Testimonials.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
