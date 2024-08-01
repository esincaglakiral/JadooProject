using AutoMapper;
using JadooProject.DataAccess.Context;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.Mediator.Commands.TestimonialCommands;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommand>
    {
        private readonly IMapper _mapper;
        private readonly JadooContext _context;

        public CreateTestimonialCommandHandler(IMapper mapper, JadooContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var mappedValues = _mapper.Map<Testimonial>(request);
            await _context.Testimonials.AddAsync(mappedValues);
            await _context.SaveChangesAsync();
        }
    }
}
