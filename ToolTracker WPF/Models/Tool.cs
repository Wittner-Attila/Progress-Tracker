namespace Models;

public class Tool
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public Level Level { get; set; }

    public List<Game> Games { get; set; }

    public Tool(int id, string name)
    {
        Id = id;
        Name = name;
    }


    public Tool(List<Game> games, int id, string name) : this(id, name)
    {
        Games = games;
    }


    public void AddGame(Game game) => Games.Add(game);

    private string GamesString()
    {
        string gamesString = string.Empty;
        foreach (Game game in Games.SkipLast(1))
        {
            gamesString += game.ToString() + ", ";
        }
        gamesString += Games.TakeLast(1).ToString();
        return gamesString;
    }

    public override string ToString()
    {
        return $"{Name} is in games:{GamesString}";
    }
}
