using CQRSProject.CQRS.Results;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handler
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ProductDescription = x.ProductDescription,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductID = x.ProductID,
                ProductImage = x.ProductImage,
            }).ToList();
            return values;
        }
    }
}
