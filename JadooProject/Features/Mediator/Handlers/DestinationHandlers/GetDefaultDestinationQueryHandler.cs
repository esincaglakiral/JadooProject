using AutoMapper;
using JadooProject.DataAccess.Context;
using JadooProject.Features.CQRS.Results.DestinationResult;
using JadooProject.Features.Mediator.Queries.DestinationQueries;
using JadooProject.Features.Mediator.Results.DestinationResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.Features.Mediator.Handlers.DestinationHandlers
{
    public class GetDefaultDestinationQueryHandler : IRequestHandler<GetDefaultDestinationQuery, List<GetDefaultDestinationQueryResult>>
    {
        private readonly JadooContext _context;
        private readonly IMapper _mapper;

        public GetDefaultDestinationQueryHandler(JadooContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<GetDefaultDestinationQueryResult>> Handle(GetDefaultDestinationQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Destinations.ToListAsync();
            return _mapper.Map<List<GetDefaultDestinationQueryResult>>(values);
        }
    }
}
