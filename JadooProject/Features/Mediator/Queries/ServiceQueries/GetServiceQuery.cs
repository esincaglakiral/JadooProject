using JadooProject.Features.Mediator.Results.ServiceResult;
using MediatR;

namespace JadooProject.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceQuery :IRequest<List<GetServiceQueryResult>>  //dönüş türü, liste türünde GetServiceQueryResult sınıfımız döner
    {
    }
}
