namespace ToolTracker_WPF.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    private readonly GameViewModel _gameViewModel = new GameViewModel();
    private readonly LevelViewModel _levelViewModel = new LevelViewModel();
    private readonly ToolViewModel _toolViewModel = new ToolViewModel();

    [ObservableProperty]
    public object _currentView = new object();

    public MainWindowViewModel()
    {
        _currentView = _gameViewModel;
    }

    [RelayCommand]
    private void ShowGameView()
    {
        CurrentView = _gameViewModel;
    }

    [RelayCommand]
    private void ShowLevelView()
    {
        CurrentView = _levelViewModel;
    }

    [RelayCommand]
    private void ShowToolView()
    {
        CurrentView = _toolViewModel;
    }
}
