namespace JadooProject.Features.CQRS.Queries.NewsQueries
{
    public class GetNewsByIdQuery
    {
        public int Id { get; set; }
        public GetNewsByIdQuery(int id)
        {
            Id = id;
        }
    }
}
