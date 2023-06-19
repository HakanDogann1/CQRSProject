using CQRSProject.CQRS.Queries;
using CQRSProject.CQRS.Results;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handler
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var value = _context.Products.Find(query.Id);
            GetProductByIdQueryResult result = new GetProductByIdQueryResult()
            {
                ProductDescription = value.ProductDescription,
                ProductName = value.ProductName,
                ProductID = value.ProductID,
                ProductImage = value.ProductImage,
                ProductPrice = value.ProductPrice,
            };
            return result;
        }
    }
}
