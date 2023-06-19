using CQRSProject.CQRS.Queries;
using CQRSProject.CQRS.Results;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handler
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateByIdQueryResult Handle(GetProductUpdateByIdQuery query)
        {
            var value = _context.Products.Find(query.Id);
            return new GetProductUpdateByIdQueryResult
            {
                ProductDescription = value.ProductDescription,
                ProductName = value.ProductName,
                ProductID = value.ProductID,
                ProductPrice = value.ProductPrice,
                ProductImage = value.ProductImage,
            };
            
        }
    }
}
