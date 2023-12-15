namespace Api_Back_End_PI.DTO
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Buyers { get; set; }

    }
}
