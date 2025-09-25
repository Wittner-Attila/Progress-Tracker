namespace ToolTracker_WPF.ViewModels;

public partial class ToolViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Tool> tools = new ObservableCollection<Tool> { new Tool(1, "Crude"), new Tool(2, "Modern"), new Tool(3, "Hi-Tech"), };

    [ObservableProperty]
    public Tool currentTool;

    public ToolViewModel()
    {
        CurrentTool = null;
    }

    [RelayCommand]
    private void ViewTool(Tool tool) => SetCurrentTool(tool);

    private void SetCurrentTool(Tool tool)
    {
        CurrentTool = tool;
    }
}
