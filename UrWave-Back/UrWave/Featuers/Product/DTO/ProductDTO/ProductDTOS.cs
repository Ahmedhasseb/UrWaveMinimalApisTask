namespace UrWave.Featuers.Product.DTO.ProductDTO
{
    public  record class ProductDTOS
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
