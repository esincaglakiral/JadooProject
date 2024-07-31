using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.Features.CQRS.Results.DestinationResult;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetLatestDestinationQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly IDestinationDal _destinationDal;

        public GetLatestDestinationQueryHandler(IMapper mapper, IDestinationDal destinationDal)
        {
            _mapper = mapper;
            _destinationDal = destinationDal;
        }


        public GetLatestDestinationQueryResult Handle()
        {
            var value = _destinationDal.GetLastDestination();
            return _mapper.Map<GetLatestDestinationQueryResult>(value);
        }
    }
}
