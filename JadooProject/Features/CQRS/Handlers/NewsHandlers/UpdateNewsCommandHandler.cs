using AutoMapper;
using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.NewsCommand;

namespace JadooProject.Features.CQRS.Handlers.NewsHandlers
{
    public class UpdateNewsCommandHandler
    {
        private readonly IRepository<News> _repository;

        private readonly IMapper _mapper;

        public UpdateNewsCommandHandler(IRepository<News> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public void Handle(UpdateNewsCommand command)
        {
            var value = _mapper.Map<News>(command);
            _repository.Update(value);
        }
    }
}
