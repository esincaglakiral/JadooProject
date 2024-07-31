using JadooProject.Features.Mediator.Results.ServiceResult;
using JadooProject.Features.Mediator.Results.TestimonialResult;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery : IRequest<GetTestimonialByIdQueryResult>
    {
        public int Id { get; set; }
        public GetTestimonialByIdQuery(int id)
        {
            Id = id;
        }

    }
}
