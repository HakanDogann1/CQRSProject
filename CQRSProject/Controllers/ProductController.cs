using CQRSProject.CQRS.Command;
using CQRSProject.CQRS.Handler;
using CQRSProject.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductQueryCommand _createProductQueryCommand;
        private readonly GetProductUpdateByIdQueryHandler _getProductUpdateByIdQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;
        private readonly DeleteProductCommandHandler _deleteProductCommandHandler;
        private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;

        public ProductController(GetProductQueryHandler getProductQueryHandler, CreateProductQueryCommand createProductQueryCommand, GetProductUpdateByIdQueryHandler getProductUpdateByIdQueryHandler, UpdateProductCommandHandler updateProductCommandHandler, DeleteProductCommandHandler deleteProductCommandHandler, GetProductByIdQueryHandler getProductByIdQueryHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductQueryCommand = createProductQueryCommand;
            _getProductUpdateByIdQueryHandler = getProductUpdateByIdQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand createProductCommand)
        {
            _createProductQueryCommand.Handle(createProductCommand);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = _getProductUpdateByIdQueryHandler.Handle(new GetProductUpdateByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand updateProductCommand)
        {
            _updateProductCommandHandler.Handle(updateProductCommand);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            _deleteProductCommandHandler.Handle(new DeleteProductByIdQuery(id));
            return RedirectToAction("Index");
        }

        public IActionResult GetByID(int id)
        {
            var value = _getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
            return View(value);
        }


    }
}
