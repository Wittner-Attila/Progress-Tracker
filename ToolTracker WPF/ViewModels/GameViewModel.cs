namespace ToolTracker_WPF.ViewModels;

public partial class GameViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Game> games = new ObservableCollection<Game> { new Game(1, "test", "test"), new Game(2, "Béla", "Bár"), new Game(3, "Arborétum", "Kert"), };

    [ObservableProperty]
    public Game currentGame;

    public GameViewModel()
    {
        CurrentGame = null;
    }

    [RelayCommand]
    private void ViewGame(Game game) => SetCurrentGame(game);

    private void SetCurrentGame(Game game)
    {
        CurrentGame = game;
    }
}
