using CQRSProject.CQRS.Command;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handler
{
    public class CreateProductQueryCommand
    {
        private readonly Context _context;

        public CreateProductQueryCommand(Context context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            Product product = new Product()
            {
                ProductDescription = command.ProductDescription,
                ProductName = command.ProductName,
                ProductImage = command.ProductImage,
                ProductPrice = command.ProductPrice,
            };
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
