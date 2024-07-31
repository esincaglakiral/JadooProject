namespace JadooProject.Features.CQRS.Results.ManuelResult
{
    public class GetManuelByIdQueryResult
    {
        public int ManuelId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
