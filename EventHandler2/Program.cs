class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        UI ui = new UI();
        Test test = new Test();

        ui.Subscribe(game);
        ui.SubscribeDoubleScore(game);

        test.Subscribe(game);

        game.AddScore(10);
    }
}

class ScoreEventArgs : EventArgs
{
    public int Score { get; set; }
}

class Game
{
    public event EventHandler<ScoreEventArgs> OnScoreChanged;

    // public delegate void <ScoreEventArgs> OnScoreChanged(object sender, ScoreEventArgs e);

    public void AddScore(int score)
    {
        OnScoreChanged?.Invoke(this, new ScoreEventArgs { Score = score });
    }

    public void Unsubscribe(UI ui)
    {
        OnScoreChanged -= ui.UpdateScore;
    }
}

class UI
{
    public void Subscribe(Game game)
    {
        game.OnScoreChanged += UpdateScore;
    }

    public void SubscribeDoubleScore(Game game)
    {
        game.OnScoreChanged += UpdateDoubleScore;
    }

    public void UpdateScore(object sender, ScoreEventArgs e)
    {
        Console.WriteLine(sender.GetType().Name);
        Console.WriteLine($"Score sekarang: {e.Score}");
    }

    public void UpdateDoubleScore(object sender, ScoreEventArgs e)
    {
        Console.WriteLine($"Double Score sekarang: {e.Score * 2}");
    }
}

class Test
{
    public void Subscribe(Game game)
    {
        game.OnScoreChanged += AddBonusScore;
    }

    public void AddBonusScore(object sender, ScoreEventArgs e)
    {
        Console.WriteLine($"[TEST] Bonus Score: {e.Score + 5}");
    }
}
