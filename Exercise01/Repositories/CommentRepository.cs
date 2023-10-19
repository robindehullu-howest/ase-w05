namespace Howest.MCT.Excercise01.Repositories;

public interface ICommentRepository
{
    Task<List<Comment>> GetCommentsOfPost(int postId);
}

public class CommentRepository: ICommentRepository
{
    public async Task<List<Comment>> GetCommentsOfPost(int postId)
    {
        var client = new HttpClient();
        var response = await client.GetAsync($"{Global.BASE_URL}/posts/{postId}/comments");
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<List<Comment>>(content);
    }
}