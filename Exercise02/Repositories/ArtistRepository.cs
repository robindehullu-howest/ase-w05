namespace Howest.MCT.Excercise02.Repositories;

public interface IArtistRepository
{
    Task<List<Artist>> GetArtists();
}

public class ArtistRepository: IArtistRepository
{
    public async Task<List<Artist>> GetArtists()
    {
        var client = new HttpClient();
        var response = await client.GetAsync($"{Global.BASE_URL}/artists");
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Artist>>(content);
    }
}