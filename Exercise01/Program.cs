
var todapplicationService = new TodoApplicationService();
var posts = await todapplicationService.GetPosts();

foreach (var post in posts)
{
    Console.WriteLine(post);
}


var post1 = await todapplicationService.GetPost(1);
Console.WriteLine(post1);


var post2 = new Post
{
    UserId = 1,
    Title = "My new post",
    Body = "This is my new post"
};

var result = await todapplicationService.CreatePost(post2);
Console.WriteLine(result);


var comments = await todapplicationService.GetCommentsOfPost(1);

foreach (var comment in comments)
{
    Console.WriteLine(comment);
}


var (p, c) = await todapplicationService.GetPostAndComments(1);
Console.WriteLine(p);

Console.WriteLine("\nComments:");
foreach (var comment in c)
{
    Console.WriteLine(comment);
}