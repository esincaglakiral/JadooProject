using JadooProject.Features.Mediator.Results.ServiceResult;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceByIdQuery :IRequest<GetServiceByIdQueryResult>
    {
        public int Id { get; set; }

        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }
    }
}
