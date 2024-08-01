using JadooProject.Features.Mediator.Results.DestinationResults;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.DestinationQueries
{
    public class GetDestinationsDetailsQuery : IRequest<GetDestinationDetailsQueryResult>
    {
        public int Id { get; set; }

        public GetDestinationsDetailsQuery(int id)
        {
            Id = id;
        }
    }
}
