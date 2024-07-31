using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Results.NewsResult;

namespace JadooProject.Features.CQRS.Handlers.NewsHandlers
{
    public class GetNewsQueryHandler
    {
        private readonly IRepository<News> _repository;
        private readonly IMapper _mapper;

        public GetNewsQueryHandler(IRepository<News> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<GetNewsQueryResult> Handle()
        {
            var value = _repository.GetList();
            return _mapper.Map<List<GetNewsQueryResult>>(value);
        }
    }
}
