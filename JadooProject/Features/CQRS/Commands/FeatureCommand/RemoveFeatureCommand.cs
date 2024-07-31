namespace JadooProject.Features.CQRS.Commands.FeatureCommand
{
    public class RemoveFeatureCommand
    {
        public RemoveFeatureCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
