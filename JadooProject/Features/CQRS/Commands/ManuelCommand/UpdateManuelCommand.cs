namespace JadooProject.Features.CQRS.Commands.ManuelCommand
{
    public class UpdateManuelCommand
    {
        public int ManuelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
