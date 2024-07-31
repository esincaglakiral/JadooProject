namespace JadooProject.Features.CQRS.Commands.NewsCommand
{
    public class RemoveNewsCommand
    {
        public int Id { get; set; }

        public RemoveNewsCommand(int id)
        {
            Id = id;
        }
    }
}
