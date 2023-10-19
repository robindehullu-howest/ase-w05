var MusicEntertainmentService = new MusicEntertainmentService();
bool exitRequested = false;

while (!exitRequested)
{
    Console.WriteLine("1. Get all artists");
    Console.WriteLine("2. Get all concerts");
    Console.WriteLine("3. Get artist and their concerts");
    Console.WriteLine("4. Exit");

    int request = int.Parse(Console.ReadLine());

    switch (request)
    {
        case 1:
            List<Artist> artists = await MusicEntertainmentService.GetArtists();
            foreach (Artist artist in artists)
            {
                Console.WriteLine(artist);
            }
            break;
        case 2:
            List<Concert> concerts = await MusicEntertainmentService.GetConcerts();
            foreach (Concert concert in concerts)
            {
                Console.WriteLine(concert);
            }
            break;
        case 3:
            Console.WriteLine("Enter artist id");
            int artistId = int.Parse(Console.ReadLine());

            Artist a = await MusicEntertainmentService.GetArtist(artistId);
            Console.WriteLine(a);

            List<Concert> concertsByArtist = await MusicEntertainmentService.GetConcertsByArtist(artistId);
            foreach (Concert concert in concertsByArtist)
            {
                Console.WriteLine(concert);
            }
            break;

        case 4:
            exitRequested = true;
            break;

        default:
            Console.WriteLine("Invalid request");
            break;
    }
}