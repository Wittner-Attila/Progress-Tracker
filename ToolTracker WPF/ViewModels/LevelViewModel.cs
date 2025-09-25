namespace ToolTracker_WPF.ViewModels;

public partial class LevelViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Level> levels = new ObservableCollection<Level> { new Level(1, "Crude", 1), new Level(2, "Modern", 2), new Level(3, "Hi-Tech", 3), };

    [ObservableProperty]
    public Level currentLevel;

    public LevelViewModel()
    {
        CurrentLevel = null;
    }

    [RelayCommand]
    private void ViewLevel(Level level) => SetCurrentLevel(level);

    private void SetCurrentLevel(Level level)
    {
        CurrentLevel = level;
    }
}
