namespace Howest.MCT.Excercise02.Repositories;

public interface IConcertRepository
{
    Task<List<Concert>> GetConcerts();
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
}
