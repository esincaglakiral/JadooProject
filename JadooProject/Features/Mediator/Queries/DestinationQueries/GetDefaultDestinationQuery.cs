using JadooProject.Features.CQRS.Results.DestinationResult;
using JadooProject.Features.Mediator.Results.DestinationResults;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.DestinationQueries
{
    public class GetDefaultDestinationQuery : IRequest<List<GetDefaultDestinationQueryResult>>
    {
    }
}
