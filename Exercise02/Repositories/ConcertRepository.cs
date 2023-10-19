namespace Howest.MCT.Excercise02.Repositories;

public interface IConcertRepository
{
    Task<List<Concert>> GetConcerts();
    Task<Concert> GetConcert(int id);
}

public class ConcertRepository: IConcertRepository
{
    public async Task<List<Concert>> GetConcerts()
    {
        var client = new HttpClient();
        var response = await client.GetAsync($"{Global.BASE_URL}/concerts");
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Concert>>(content);
    }

    public async Task<Concert> GetConcert(int id)
    {
        List<Concert> concerts = await GetConcerts();
        return concerts.FirstOrDefault(c => c.Id == id);
    }
}
