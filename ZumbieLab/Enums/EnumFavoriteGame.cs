using System.ComponentModel.DataAnnotations;

namespace ZumbieLab.Enums
{
    public enum EnumFavoriteGame
    {
        [Display(Name = "Counter Strike")]
        CounterStrike,
        [Display(Name = "Minecraft")]
        Minecraft,
        [Display(Name = "Fortnite")]
        Fortnite,
        [Display(Name = "The Witcher")]
        TheWitcher,
        [Display(Name = "Valorant")]
        Valorant,
        [Display(Name = "Assassins Creed")]
        AssassinsCreed,
        [Display(Name = "World of Warcraft")]
        WorldOfWarcraft,
        [Display(Name = "FIFA")]
        FIFA,
        [Display(Name = "League of Legends")]
        LeagueOfLegends,
        [Display(Name = "Dota")]
        Dota,
        [Display(Name = "Rocket League")]
        RocketLeague,
        [Display(Name = "Outro")]
        Other
    }
}