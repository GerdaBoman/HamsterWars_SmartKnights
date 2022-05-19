using HamsterWars.Shared.Models;

namespace HamsterWars.Server.Data;

public class DataSeeding
{
    public static void SeedData(HamsterWarsContext context)
    {

        if (context.Hamster.Any())
        {
            return;
        }

        var hamster = new Hamster[]
        {
                new Hamster{Name="Naima", Age=1, FavFood="Pasta",Loves="Running",ImgName="hamster-1.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Kofi", Age=2, FavFood="Tomato",Loves="Writing",ImgName="hamster-2.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Safwan", Age=3, FavFood="Brown Rice",Loves="Staring",ImgName="hamster-3.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Angelica", Age=4, FavFood="Melon",Loves="Eating",ImgName="hamster-4.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Humayra", Age=1, FavFood="Tart",Loves="Living",ImgName="hamster-5.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Aysha", Age=0, FavFood="Coconut",Loves="People",ImgName="hamster-6.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Abel", Age=2, FavFood="Saffron",Loves="Playing",ImgName="hamster-7.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Owen", Age=3, FavFood="Capers",Loves="Sun",ImgName="hamster-8.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Saad", Age=1, FavFood="Poppy Seeds",Loves="Rain",ImgName="hamster-9.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Alexandre", Age=2, FavFood="Baguette",Loves="Cycling",ImgName="hamster-10.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Luela", Age=1, FavFood="Curry Powder",Loves="Cake",ImgName="hamster-11.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Bryoni", Age=2, FavFood="Licorice",Loves="Cars",ImgName="hamster-12.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Umar", Age=0, FavFood="Cornflakes",Loves="Fighting",ImgName="hamster-13.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Betsy", Age=0, FavFood="Pomelo",Loves="Running",ImgName="hamster-14.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Oskar", Age=2, FavFood="Endive",Loves="Playing cards",ImgName="hamster-15.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Adnaan", Age=3, FavFood="Waffle",Loves="Having fun",ImgName="hamster-16.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Israel", Age=4, FavFood="Wine",Loves="Going to Disco",ImgName="hamster-17.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Jorge", Age=1, FavFood="Red Cabbage",Loves="Dancing",ImgName="hamster-18.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Kate", Age=3, FavFood="Toast",Loves="Laughing",ImgName="hamster-19.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Bob", Age=1, FavFood="Onion",Loves="Cycling",ImgName="hamster-20.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Rivka", Age=1, FavFood="Chives",Loves="Listening to music",ImgName="hamster-21.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Alasdair", Age=1, FavFood="Curry paste",Loves="Environment",ImgName="hamster-22.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Zain", Age=0, FavFood="Pear",Loves="Trees",ImgName="hamster-23.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Lee", Age=2, FavFood="Kumquat",Loves="Flowers",ImgName="hamster-24.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Shauna", Age=1, FavFood="Nectar",Loves="Sleeping",ImgName="hamster-25.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Roy", Age=3, FavFood="Orange",Loves="Laughing",ImgName="hamster-26.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Vincenzo", Age=1, FavFood="Pecan",Loves="Reading",ImgName="hamster-27.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Davina", Age=0, FavFood="Fig",Loves="Playing Piano",ImgName="hamster-28.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Yousaf", Age=0, FavFood="Rice",Loves="Dancing",ImgName="hamster-29.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Derrick", Age=0, FavFood="Couscous",Loves="Drinking",ImgName="hamster-30.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Ella-Grace", Age=3, FavFood="Jelly Bean",Loves="Partying",ImgName="hamster-31.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Dina", Age=4, FavFood="Kindney bean",Loves="Traveling",ImgName="hamster-32.jpg",Wins=0, Losses=0,Games=0},
                new Hamster{Name="Jordanna", Age=0, FavFood="Bagel",Loves="Baking",ImgName="hamster-33.jpg",Wins=1, Losses=0,Games=1},
                new Hamster{Name="Shania", Age=0, FavFood="Dill",Loves="Cooking",ImgName="hamster-34.jpg",Wins=0, Losses=1,Games=1},
                new Hamster{Name="Milo", Age=0, FavFood="Persimmon",Loves="Playing chess",ImgName="hamster-35.jpg",Wins=0, Losses=2,Games=2},
                new Hamster{Name="Arlo", Age=1, FavFood="Banana",Loves="Listing to heavy metal",ImgName="hamster-36.jpg",Wins=1, Losses=0,Games=1},
                new Hamster{Name="Dollie", Age=2, FavFood="Salad",Loves="",ImgName="hamster-37.jpg",Wins=0, Losses=1,Games=1},
                new Hamster{Name="Lilly-Mae", Age=1, FavFood="Cucumber",Loves="",ImgName="hamster-38.jpg",Wins=1, Losses=0,Games=1},
                new Hamster{Name="John", Age=2, FavFood="Spaghetti",Loves="Cooking",ImgName="hamster-39.jpg",Wins=1, Losses=1,Games=2},
                new Hamster{Name="Julia", Age=3, FavFood="Vegemite",Loves="Watching movies",ImgName="hamster-40.jpg",Wins=1, Losses=0,Games=1}


        };

        context.Hamster.AddRange(hamster);
        context.SaveChanges();


        var history = new History[]
         {
                new History{  BattleDate = DateTime.Now,WinnerId=40,LoserId=39},
                new History{  BattleDate = DateTime.Now, WinnerId=39,LoserId=37},
                new History{  BattleDate = DateTime.Now,WinnerId=38,LoserId=36},
                new History{  BattleDate = DateTime.Now,WinnerId=35,LoserId=34},
                new History{  BattleDate = DateTime.Now,WinnerId=33,LoserId=34}
          };



        context.History.AddRange(history);


        context.SaveChanges();
    }
}
