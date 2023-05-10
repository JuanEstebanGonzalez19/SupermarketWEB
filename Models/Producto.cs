namespace SupermarketWEB.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Valor { get; set; }
        public string? Description { get; set; }
        public ICollection<Product>? Products { get; set; } = default!;
    }
}
