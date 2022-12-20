//Creating a Video Game List

List<string> games = new List<string>();

//Adding Games to the List. 

games.Add("Pokemon Red");
games.Add("Super Mario Oddysey");
games.Add("The Legend of Zelda");
games.Add("Star Fox 64");
games.Add("Dragon Quest");

var gameLength = games.OrderBy(x => x.Length);

foreach (var game in gameLength)
{
    Console.WriteLine(game);
}