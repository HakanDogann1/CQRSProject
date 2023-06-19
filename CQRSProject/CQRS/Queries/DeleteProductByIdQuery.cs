namespace CQRSProject.CQRS.Queries
{
    public class DeleteProductByIdQuery
    {
        public int Id { get; set; }

        public DeleteProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
