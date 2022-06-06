using HamsterWars.Shared.Entity;

namespace FrontEndLogic;

public  class Procentage
{
    public double WinPercentage(Hamster hamster)
    {
        double wins = Convert.ToDouble(hamster.Wins);
        double totalGames = Convert.ToDouble(hamster.Games);
        double percentage = Math.Round(((wins / totalGames) * 100), 2);
        return percentage;
    }
    public double LossPercentage(Hamster hamster)
    {
        double loss = Convert.ToDouble(hamster.Losses);
        double totalGames = Convert.ToDouble(hamster.Games);
        double percentage = Math.Round(((loss/ totalGames) * 100), 2);
        return percentage;
    }
}
