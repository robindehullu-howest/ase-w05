namespace Howest.MCT.Excercise02.Models;
public class Concert 
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("genre")]
    public string Genre { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("price")]
    public double Price { get; set; }

    [JsonProperty("date")]
    public DateTime Date { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Name: {Name}");
        sb.AppendLine($"Genre: {Genre}");
        sb.AppendLine($"Country: {Country}");
        sb.AppendLine($"Price: {Price}");
        sb.AppendLine($"Date: {Date}");
        return sb.ToString();
    }
}