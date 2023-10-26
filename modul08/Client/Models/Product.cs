public class Product
{
    public string Name { get; set; }
    public string Category { get; set; } = "None";
    public decimal Price { get; set; }
    public DateTime PublishedDate { get; set; } = DateTime.Now;

    public override string ToString()
    {
        return $"Navn: {Name}, Kategori: {Category}, Pris: {Price}, Dato: {PublishedDate.ToShortDateString()}";
    }
}