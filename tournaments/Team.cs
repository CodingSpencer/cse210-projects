public class Team
{
    private List<Player> _players = new List<Player>();
    private string _name;

    private int _wins = 0; 
    private int _losses = 0; 


    public Team(string name)
    {
        _name = name;
    }

    public void AddPlayer(Player p)
    {
        _players.Add(p);
    }

    public void DisplayRoster()
    {
        Console.WriteLine($"{_name}");
        foreach (Player player in _players)
        {
            Console.WriteLine(player.Display());
            Console.WriteLine($"Wins: {_wins} Losses: {_losses}");
        }
    }

    public void AddWin()
    {
        _wins += 1;
    }

    public void AddLoss()
    {
        _losses += 1;
    }
}