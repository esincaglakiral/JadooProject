using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.DestinationCommand;

namespace JadooProject.Features.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly IRepository<Destination> _repository;
        private readonly IMapper _mapper;

        public CreateDestinationCommandHandler(IRepository<Destination> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Handle(CreateDestinationCommand command)
        {
            var mappedValues = _mapper.Map<Destination>(command);
            _repository.Create(mappedValues);
        }
    }
}
