using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.ManuelCommand;
using JadooProject.Features.CQRS.Commands.NewsCommand;

namespace JadooProject.Features.CQRS.Handlers.NewsHandlers
{
    public class CreateNewsCommandHandler
    {
        private readonly IRepository<News> _repository;

        private readonly IMapper _mapper;

        public CreateNewsCommandHandler(IRepository<News> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public void Handle(CreateNewsCommand command)
        {
            var values = _mapper.Map<News>(command);
            _repository.Create(values);
        }

    }
}
