using AutoMapper;
using JadooProject.DataAccess.Context;
using JadooProject.Features.Mediator.Queries.DestinationQueries;
using JadooProject.Features.Mediator.Results.DestinationResults;
using MediatR;

namespace JadooProject.Features.Mediator.Handlers.DestinationHandlers
{
    public class GetDestinationDetailsQueryHandler : IRequestHandler<GetDestinationsDetailsQuery, GetDestinationDetailsQueryResult>
    {
        private readonly JadooContext _jadooContext;
        private readonly IMapper _mapper;

        public GetDestinationDetailsQueryHandler(JadooContext jadooContext, IMapper mapper)
        {
            _jadooContext = jadooContext;
            _mapper = mapper;
        }

        public async Task<GetDestinationDetailsQueryResult> Handle(GetDestinationsDetailsQuery request, CancellationToken cancellationToken)
        {
            var value = await _jadooContext.Destinations.FindAsync(request.Id);
            return _mapper.Map<GetDestinationDetailsQueryResult>(value);
        }
    }
}
