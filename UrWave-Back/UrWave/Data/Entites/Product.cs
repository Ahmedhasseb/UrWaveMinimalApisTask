using UrWave.Data.Model.enums;

namespace UrWave.Data.Model
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }=DateTime.Now;
        public string ImageUrl {  get; set; }
        public Status states { get; set; }
    }
}
