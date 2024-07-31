using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.ManuelCommand;

namespace JadooProject.Features.CQRS.Handlers.ManuelHandlers
{
    public class UpdateManuelCommandHandler
    {
        private readonly IRepository<Manuel> _repository;

        private readonly IMapper _mapper;

        public UpdateManuelCommandHandler(IRepository<Manuel> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public void Handle(UpdateManuelCommand command)
        {
            var value = _mapper.Map<Manuel>(command);
            _repository.Update(value);
        }
    }
}
