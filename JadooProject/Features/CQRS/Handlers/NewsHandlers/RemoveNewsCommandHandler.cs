using JadooProject.DataAccess.Abstract;
using JadooProject.DataAccess.Entities;
using JadooProject.Features.CQRS.Commands.NewsCommand;

namespace JadooProject.Features.CQRS.Handlers.NewsHandlers
{
    public class RemoveNewsCommandHandler
    {
        private readonly IRepository<News> _repository;

        public RemoveNewsCommandHandler(IRepository<News> repository)
        {
            _repository = repository;
        }


        public void Handle(RemoveNewsCommand command)
        {
            _repository.Delete(command.Id);
        }
    }
}
