﻿namespace CQRSProject.CQRS.Results
{
    public class GetProductUpdateByIdQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public int ProductPrice { get; set; }
    }
}
