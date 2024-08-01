using JadooProject.Features.Mediator.Results.TestimonialResult;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialDashboardQuery : IRequest<List<GetTestimonialForDashboardQueryResult>>
    {
    }
}
