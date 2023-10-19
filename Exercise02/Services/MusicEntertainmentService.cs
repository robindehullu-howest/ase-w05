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

    public async Task<Artist> GetArtist(int id) => await _artistRepository.GetArtist(id);

    public async Task<List<Concert>> GetConcerts() => await _concertRepository.GetConcerts();

    public async Task<Concert> GetConcert(int id) => await _concertRepository.GetConcert(id);

    public async Task<List<Concert>> GetConcertsByArtist(int artistId)
    {
        Artist artist = await _artistRepository.GetArtist(artistId);
        List<Concert> concerts = new List<Concert>();
        foreach (int concertId in artist.ConcertIds)
        {
            Concert concert = await _concertRepository.GetConcert(concertId);
            concerts.Add(concert);
        }
        return concerts;
    }
}