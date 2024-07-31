namespace JadooProject.Features.CQRS.Commands.BrandCommand
{
    public class UpdateBrandCommand
    {
        public int BrandId { get; set; }
        public string ImageUrl { get; set; }
    }
}
