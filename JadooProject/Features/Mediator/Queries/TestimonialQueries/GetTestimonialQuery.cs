using JadooProject.Features.Mediator.Results.ServiceResult;
using JadooProject.Features.Mediator.Results.TestimonialResult;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
    {
    }
}
