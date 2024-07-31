using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.ManuelCommand;

namespace JadooProject.Features.CQRS.Handlers.ManuelHandlers
{
    public class CreateManuelCommandHandler
    {
        private readonly IRepository<Manuel> _repository;

        private readonly IMapper _mapper;

        public CreateManuelCommandHandler(IRepository<Manuel> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public void Handle(CreateManuelCommand command)
        {
            var values = _mapper.Map<Manuel>(command);
            _repository.Create(values);
        }
    }
}
