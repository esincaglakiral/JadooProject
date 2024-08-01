using AutoMapper;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.Mediator.Commands.TestimonialCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
    {
        private readonly JadooContext _context;
        private readonly IMapper _mapper;

        public UpdateTestimonialCommandHandler(JadooContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var mappedValues = _mapper.Map<Testimonial>(request);
            _context.Testimonials.Update(mappedValues);
            await _context.SaveChangesAsync();
        }
    }
}
