namespace Howest.MCT.Excercise01.Repositories;

public interface ITodoApplicationService
{
    Task<List<Post>> GetPosts();
    Task<Post> GetPost(int id);
    Task<string> CreatePost(Post post);
    Task<List<Comment>> GetCommentsOfPost(int postId);
    Task<(Post, List<Comment>)> GetPostAndComments(int postId);
}

public class TodoApplicationService : ITodoApplicationService
{

    private IPostRepository _postRepository;
    private ICommentRepository _commentRepository;

    public TodoApplicationService()
    {
        _postRepository = new PostRepository();
        _commentRepository = new CommentRepository();
    }

    public async Task<List<Post>> GetPosts() => await _postRepository.GetPosts();

    public async Task<Post> GetPost(int id) => await _postRepository.GetPost(id);

    public async Task<string> CreatePost(Post post) => await _postRepository.CreatePost(post);

    public async Task<List<Comment>> GetCommentsOfPost(int postId) => await _commentRepository.GetCommentsOfPost(postId);

    public async Task<(Post, List<Comment>)> GetPostAndComments(int postId)
    {
        var post = await GetPost(postId);
        var comments = await GetCommentsOfPost(postId);
        return (post, comments);
    }

}