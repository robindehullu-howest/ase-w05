namespace Howest.MCT.Excercise02.Models;

public class Artist 
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("genre")]
    public string Genre { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("concertIds")]
    public List<int> ConcertIds { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Name: {Name}");
        sb.AppendLine($"Genre: {Genre}");
        sb.AppendLine($"Country: {Country}");
        return sb.ToString();
    }
}