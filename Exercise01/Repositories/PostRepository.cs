using System.Runtime.CompilerServices;

namespace Howest.MCT.Excercise01.Repositories;

public interface IPostRepository
{
    Task<List<Post>> GetPosts();
    Task<Post> GetPost(int id);
    Task<string> CreatePost(Post post);
}

public class PostRepository : IPostRepository
{
    public async Task<List<Post>> GetPosts()
    {
        var client = new HttpClient();
        var response = await client.GetAsync($"{Global.BASE_URL}/posts");
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Post>>(content);
    }

    public async Task<Post> GetPost(int id)
    {
        var client = new HttpClient();
        var response = await client.GetAsync($"{Global.BASE_URL}/posts/{id}");
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<Post>(content);
    }

    public async Task<string> CreatePost(Post post)
    {
        var client = new HttpClient();
        var json = JsonConvert.SerializeObject(post);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await client.PostAsync($"{Global.BASE_URL}/posts", data);
        var content = await response.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject(content).ToString();
    }

}