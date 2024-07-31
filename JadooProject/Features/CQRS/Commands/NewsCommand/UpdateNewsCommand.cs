namespace JadooProject.Features.CQRS.Commands.NewsCommand
{
    public class UpdateNewsCommand
    {
        public int NewsId { get; set; }
        public string Email { get; set; }
    }
}
