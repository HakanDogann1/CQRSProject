namespace CQRSProject.CQRS.Command
{
    public class CreateProductCommand
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public int ProductPrice { get; set; }
    }
}
