using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.Features.CQRS.Results.DestinationResult;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationDashboardQueryHandler
    {
        private readonly IDestinationDal _destinationDal;

        private readonly IMapper _mapper;

        public GetDestinationDashboardQueryHandler(IDestinationDal destinationDal, IMapper mapper)
        {
            _destinationDal = destinationDal;
            _mapper = mapper;
        }
        public List<GetDestinationDashboardQueryResult> Handle()
        {
            var value = _destinationDal.GetLast6Destination();
            return _mapper.Map<List<GetDestinationDashboardQueryResult>>(value);

        }

    }
}
