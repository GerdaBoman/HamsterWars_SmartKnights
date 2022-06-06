
using FrontEndLogic;
using HamsterWars.Shared.Entity;

namespace HamsterWars.Client.Pages;

public partial class Battle
{
    Procentage procentage = new();


    Hamster firstHamster = new();
    Hamster secondHamster = new();

    Hamster winnerHamster = new();
    Hamster loserHamster = new();

    bool result = false;

    int win = 1;
    int lost = 1;
    int game = 1;

 

    protected override async Task OnInitializedAsync()
    {
        firstHamster = await hamsterService.GetRandomHamster();
        secondHamster = await hamsterService.GetRandomHamster();
        await CheckForDublicateHamster(firstHamster, secondHamster);
    }

    async Task UpdateHamster(Hamster hamster)
    {
        await hamsterService.UpdateHamster(hamster);
    }

    

    void  ChosenWinner(int id)
    {
        if (id == firstHamster.Id)
        {
            firstHamster.Wins = firstHamster.Wins + win;
            secondHamster.Losses = secondHamster.Losses + lost;

            firstHamster.Games = firstHamster.Games + game;
            secondHamster.Games = secondHamster.Games + game;

            UpdateHamster(firstHamster);
            UpdateHamster(secondHamster);

            winnerHamster = firstHamster;
            loserHamster = secondHamster;

            double winnerStatistics = procentage.WinPercentage(winnerHamster);

            NewBattle();
            result = true;
        }
        else
        {
            secondHamster.Wins = secondHamster.Wins + win;
            firstHamster.Losses = firstHamster.Losses + lost;

            firstHamster.Games = firstHamster.Games + game;
            secondHamster.Games = secondHamster.Games + game;

            UpdateHamster(firstHamster);
            UpdateHamster(secondHamster);

            winnerHamster = secondHamster;
            loserHamster = firstHamster;

            double winnerStatistics = procentage.WinPercentage(winnerHamster);

            NewBattle();
            result = true;
        }
    }

   

    async Task NewBattle()
    {
        firstHamster = await hamsterService.GetRandomHamster();
        secondHamster = await hamsterService.GetRandomHamster();

        CheckForDublicateHamster(firstHamster, secondHamster);

        StateHasChanged();
    }

    async Task CheckForDublicateHamster(Hamster firstH, Hamster secondH)
    {
        while (firstH.Id == secondH.Id)
        {
            secondHamster = await hamsterService.GetRandomHamster();
        }
    }
}