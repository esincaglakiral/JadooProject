using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Queries.BrandQueries;
using JadooProject.Features.CQRS.Results.BrandResult;

namespace JadooProject.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;
        private readonly IMapper _mapper;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public GetBrandByIdQueryResult Handle(GetBrandByIdQuery query)
        {
            var value = _repository.GetById(query.Id);
            return _mapper.Map<GetBrandByIdQueryResult>(value);
        }
    }
}
