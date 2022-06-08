using HamsterWars.Shared.Entity;

namespace DataAccess.Data;

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
                new Hamster{Name="Naima", Age=1, FavFood="Pasta",Loves="Running",ImgName="hamster-1.jpg",Wins=2, Losses=8,Games=10},
                new Hamster{Name="Kofi", Age=2, FavFood="Tomato",Loves="Writing",ImgName="hamster-2.jpg",Wins=4, Losses=7,Games=11},
                new Hamster{Name="Safwan", Age=3, FavFood="Brown Rice",Loves="Staring",ImgName="hamster-3.jpg",Wins=8, Losses=4,Games=12},
                new Hamster{Name="Angelica", Age=4, FavFood="Melon",Loves="Eating",ImgName="hamster-4.jpg",Wins=11, Losses=2,Games=13},
                new Hamster{Name="Humayra", Age=1, FavFood="Tart",Loves="Living",ImgName="hamster-5.jpg",Wins=1, Losses=2,Games=3},
                new Hamster{Name="Aysha", Age=0, FavFood="Coconut",Loves="People",ImgName="hamster-6.jpg",Wins=4, Losses=1,Games=5},
                new Hamster{Name="Abel", Age=2, FavFood="Saffron",Loves="Playing",ImgName="hamster-7.jpg",Wins=22, Losses=2,Games=24},
                new Hamster{Name="Owen", Age=3, FavFood="Capers",Loves="Sun",ImgName="hamster-8.jpg",Wins=23, Losses=19,Games=42},
                new Hamster{Name="Saad", Age=1, FavFood="Poppy Seeds",Loves="Rain",ImgName="hamster-9.jpg",Wins=12, Losses=33,Games=45},
                new Hamster{Name="Alexandre", Age=2, FavFood="Baguette",Loves="Cycling",ImgName="hamster-10.jpg",Wins=51, Losses=2,Games=53},
                new Hamster{Name="Luela", Age=1, FavFood="Curry Powder",Loves="Cake",ImgName="hamster-11.jpg",Wins=1, Losses=1,Games=2},
                new Hamster{Name="Bryoni", Age=2, FavFood="Licorice",Loves="Cars",ImgName="hamster-12.jpg",Wins=5, Losses=2,Games=7},
                new Hamster{Name="Umar", Age=0, FavFood="Cornflakes",Loves="Fighting",ImgName="hamster-13.jpg",Wins=3, Losses=20,Games=23},
                new Hamster{Name="Betsy", Age=0, FavFood="Pomelo",Loves="Running",ImgName="hamster-14.jpg",Wins=34, Losses=20,Games=54},
                new Hamster{Name="Oskar", Age=2, FavFood="Endive",Loves="Playing cards",ImgName="hamster-15.jpg",Wins=11, Losses=5,Games=16},
                new Hamster{Name="Adnaan", Age=3, FavFood="Waffle",Loves="Having fun",ImgName="hamster-16.jpg",Wins=40, Losses=13,Games=53},
                new Hamster{Name="Israel", Age=4, FavFood="Wine",Loves="Going to Disco",ImgName="hamster-17.jpg",Wins=6, Losses=6,Games=12},
                new Hamster{Name="Jorge", Age=1, FavFood="Red Cabbage",Loves="Dancing",ImgName="hamster-18.jpg",Wins=30, Losses=12,Games=42},
                new Hamster{Name="Kate", Age=3, FavFood="Toast",Loves="Laughing",ImgName="hamster-19.jpg",Wins=31, Losses=3,Games=34},
                new Hamster{Name="Bob", Age=1, FavFood="Onion",Loves="Cycling",ImgName="hamster-20.jpg",Wins=48, Losses=5,Games=53},
                new Hamster{Name="Rivka", Age=1, FavFood="Chives",Loves="Listening to music",ImgName="hamster-21.jpg",Wins=3, Losses=10,Games=13},
                new Hamster{Name="Alasdair", Age=1, FavFood="Curry paste",Loves="Environment",ImgName="hamster-22.jpg",Wins=34, Losses=31,Games=65},
                new Hamster{Name="Zain", Age=0, FavFood="Pear",Loves="Trees",ImgName="hamster-23.jpg",Wins=8, Losses=4,Games=12},
                new Hamster{Name="Lee", Age=2, FavFood="Kumquat",Loves="Flowers",ImgName="hamster-24.jpg",Wins=12, Losses=9,Games=21},
                new Hamster{Name="Shauna", Age=1, FavFood="Nectar",Loves="Sleeping",ImgName="hamster-25.jpg",Wins=23, Losses=10,Games=32},
                new Hamster{Name="Roy", Age=3, FavFood="Orange",Loves="Laughing",ImgName="hamster-26.jpg",Wins=12, Losses=1,Games=13},
                new Hamster{Name="Vincenzo", Age=1, FavFood="Pecan",Loves="Reading",ImgName="hamster-27.jpg",Wins=13, Losses=17,Games=30},
                new Hamster{Name="Davina", Age=0, FavFood="Fig",Loves="Playing Piano",ImgName="hamster-28.jpg",Wins=29, Losses=12,Games=41},
                new Hamster{Name="Yousaf", Age=0, FavFood="Rice",Loves="Dancing",ImgName="hamster-29.jpg",Wins=42, Losses=33,Games=75},
                new Hamster{Name="Derrick", Age=0, FavFood="Couscous",Loves="Drinking",ImgName="hamster-30.jpg",Wins=21, Losses=22,Games=43},
                new Hamster{Name="Ella-Grace", Age=3, FavFood="Jelly Bean",Loves="Partying",ImgName="hamster-31.jpg",Wins=23, Losses=20,Games=43},
                new Hamster{Name="Dina", Age=4, FavFood="Kindney bean",Loves="Traveling",ImgName="hamster-32.jpg",Wins=9, Losses=4,Games=13},
                new Hamster{Name="Jordanna", Age=0, FavFood="Bagel",Loves="Baking",ImgName="hamster-33.jpg",Wins=11, Losses=12,Games=23},
                new Hamster{Name="Shania", Age=0, FavFood="Dill",Loves="Cooking",ImgName="hamster-34.jpg",Wins=40, Losses=14,Games=54},
                new Hamster{Name="Milo", Age=0, FavFood="Persimmon",Loves="Playing chess",ImgName="hamster-35.jpg",Wins=33, Losses=32,Games=65},
                new Hamster{Name="Arlo", Age=1, FavFood="Banana",Loves="Listing to heavy metal",ImgName="hamster-36.jpg",Wins=3, Losses=3,Games=6},
                new Hamster{Name="Dollie", Age=2, FavFood="Salad",Loves="Tv-series",ImgName="hamster-37.jpg",Wins=12, Losses=3,Games=15},
                new Hamster{Name="Lilly-Mae", Age=1, FavFood="Cucumber",Loves="Playing poker",ImgName="hamster-38.jpg",Wins=11, Losses=2,Games=13},
                new Hamster{Name="John", Age=2, FavFood="Spaghetti",Loves="Cooking",ImgName="hamster-39.jpg",Wins=1, Losses=1,Games=2},
                new Hamster{Name="Julia", Age=3, FavFood="Vegemite",Loves="Watching movies",ImgName="hamster-40.jpg",Wins=10, Losses=3,Games=13}


        };

        context.Hamster.AddRange(hamster);
        context.SaveChanges();

    }
}
