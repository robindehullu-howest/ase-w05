namespace Howest.MCT.Excercise02.Services;

public interface IMusicEntertainmentService
{
    Task<List<Artist>> GetArtists();
    Task<Artist> GetArtist(int id);
    Task<List<Concert>> GetConcerts();
    Task<Concert> GetConcert(int id);
    Task<List<Concert>> GetConcertsByArtist(int artistId);
}

public class MusicEntertainmentService: IMusicEntertainmentService
{
    private IArtistRepository _artistRepository = new ArtistRepository();
    private IConcertRepository _concertRepository = new ConcertRepository();

    public async Task<List<Artist>> GetArtists() => await _artistRepository.GetArtists();

    public async Task<Artist> GetArtist(int id)
    {
        List<Artist> artists = await _artistRepository.GetArtists();
        return artists.FirstOrDefault(a => a.Id == id);
    }

    public async Task<List<Concert>> GetConcerts() => await _concertRepository.GetConcerts();

    public async Task<Concert> GetConcert(int id)
    {
        List<Concert> concerts =  await _concertRepository.GetConcerts();
        return concerts.FirstOrDefault(c => c.Id == id);
    }

    public async Task<List<Concert>> GetConcertsByArtist(int artistId)
    {
        Artist artist = await GetArtist(artistId);
        List<Concert> concerts = new List<Concert>();
        foreach (int concertId in artist.ConcertIds)
        {
            Concert concert = await GetConcert(concertId);
            concerts.Add(concert);
        }
        return concerts;
    }
}