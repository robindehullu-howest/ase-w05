namespace Howest.MCT.Excercise02.Repositories;

public interface IArtistRepository
{
    Task<List<Artist>> GetArtists();
    Task<Artist> GetArtist(int id);
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

    public async Task<Artist> GetArtist(int id)
    {
        List<Artist> artists = await GetArtists();
        return artists.FirstOrDefault(a => a.Id == id);
    }
}