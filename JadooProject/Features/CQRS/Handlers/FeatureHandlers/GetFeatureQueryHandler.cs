using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Results.FeatureResult;

namespace JadooProject.Features.CQRS.Handlers.FeatureHandlers
{
    public class GetFeatureQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Feature> _repository;

        public GetFeatureQueryHandler(IMapper mapper, IRepository<Feature> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }


        public List<GetFeatureQueryResult> Handle()
        {
            var value = _repository.GetList();
            return _mapper.Map<List<GetFeatureQueryResult>>(value);
        }
    }
}
