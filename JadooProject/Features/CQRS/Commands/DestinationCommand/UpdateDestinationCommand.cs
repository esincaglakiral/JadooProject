namespace JadooProject.Features.CQRS.Commands.DestinationCommand
{
    public class UpdateDestinationCommand
    {
        public int DestinationId { get; set; }

        public string ImageUrl { get; set; }

        public string City { get; set; }

        public string Duration { get; set; }

        public decimal Price { get; set; }
    }
}
