using CQRSProject.CQRS.Command;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handler
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var value = _context.Products.Find(command.ProductID);


            value.ProductDescription = command.ProductDescription;
            value.ProductName = command.ProductName;
            value.ProductImage = command.ProductImage;
            value.ProductPrice = command.ProductPrice;
            _context.Products.Update(value);
            _context.SaveChanges();

        }
    }
}
