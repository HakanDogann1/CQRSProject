using CQRSProject.CQRS.Queries;
using CQRSProject.DAL;

namespace CQRSProject.CQRS.Handler
{
    public class DeleteProductCommandHandler
    {
        private readonly Context _context;

        public DeleteProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(DeleteProductByIdQuery query)
        {
            var value = _context.Products.Find(query.Id);
            _context.Products.Remove(value);
            _context.SaveChanges();
        }
    }
}
