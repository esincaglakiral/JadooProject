namespace JadooProject.Features.CQRS.Commands.ManuelCommand
{
    public class RemoveManuelCommand
    {
        public RemoveManuelCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
