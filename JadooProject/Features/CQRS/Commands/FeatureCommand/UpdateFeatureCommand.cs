namespace JadooProject.Features.CQRS.Commands.FeatureCommand
{
    public class UpdateFeatureCommand
    {
        public int FeatureId { get; set; }
        public string FirstDescription { get; set; }
        public string SecondDescription { get; set; }
        public string ThirdDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}
