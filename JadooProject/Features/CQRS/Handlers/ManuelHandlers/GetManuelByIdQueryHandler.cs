using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Queries.ManuelQueries;
using JadooProject.Features.CQRS.Results.ManuelResult;

namespace JadooProject.Features.CQRS.Handlers.ManuelHandlers
{
    public class GetManuelByIdQueryHandler
    {
        private readonly IRepository<Manuel> _repository;

        private readonly IMapper _mapper;

        public GetManuelByIdQueryHandler(IRepository<Manuel> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public GetManuelByIdQueryResult Handle(GetManuelByIdQuery command)
        {
            var value = _repository.GetById(command.Id);
            return _mapper.Map<GetManuelByIdQueryResult>(value);
        }
    }
}
