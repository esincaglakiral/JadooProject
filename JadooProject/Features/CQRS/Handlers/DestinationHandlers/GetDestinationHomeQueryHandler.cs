using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.Features.CQRS.Results.DestinationResult;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationHomeQueryHandler
    {
        private readonly IDestinationDal _destinationDal;
        private readonly IMapper _mapper;

        public GetDestinationHomeQueryHandler(IDestinationDal destinationDal, IMapper mapper)
        {
            _destinationDal = destinationDal;
            _mapper = mapper;
        }


        public List<GetDestinationHomeQueryResult> Handle()
        {
            var value = _destinationDal.GetLast3Destination();
            return _mapper.Map<List<GetDestinationHomeQueryResult>>(value);
        }
    }
}
