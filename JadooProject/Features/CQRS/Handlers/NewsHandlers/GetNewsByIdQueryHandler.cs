using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Queries.NewsQueries;
using JadooProject.Features.CQRS.Results.NewsResult;

namespace JadooProject.Features.CQRS.Handlers.NewsHandlers
{
    public class GetNewsByIdQueryHandler
    {
        private readonly IMapper _mapper;
        private readonly IRepository<News> _repository;

        public GetNewsByIdQueryHandler(IMapper mapper, IRepository<News> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }


        public GetNewsByIdQueryResult Handle(GetNewsByIdQuery query)
        {
            var value = _repository.GetById(query.Id);
            return _mapper.Map<GetNewsByIdQueryResult>(value);


        }
    }
}
