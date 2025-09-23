namespace Models;

public class Game
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public List<Tool> Tools { get; set; }

    public Game(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }


    public Game(List<Tool> tools, int id, string name, string description): this(id, name, description)
    {
        Tools = tools;
    }


    public void AddTool(Tool tool) => Tools.Add(tool);

    private string ToolsString()
    {
        string toolsString = string.Empty;
        foreach (Tool tool in Tools.SkipLast(1))
        {
            toolsString += tool.ToString() + ", ";
        }
        toolsString += Tools.TakeLast(1).ToString();
        return toolsString;
    }

    public override string ToString()
    {
        return $"{Name} has tools:{ToolsString}";
    }

}
