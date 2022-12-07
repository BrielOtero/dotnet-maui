namespace SuperMarket.Model;
internal class Product
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public Dictionary<string, string> References { get; set; }
    public int Stock { get; set; }
    public int TargeStock { get; set; }
}
