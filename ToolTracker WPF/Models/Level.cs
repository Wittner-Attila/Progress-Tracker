namespace Models;

public class Level
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int LevelNumber { get; set; }

    public Level(int id, string name, int levelNumber)
    {
        Id = id;
        Name = name;
        LevelNumber = levelNumber;
    }

    public override string ToString()
    {
        return $"{this.Name} -> {this.LevelNumber}";
    }
}
