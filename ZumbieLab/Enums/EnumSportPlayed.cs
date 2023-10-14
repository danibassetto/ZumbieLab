using System.ComponentModel.DataAnnotations;

namespace ZumbieLab.Enums
{
    public enum EnumSportPlayed
    {
        [Display(Name = "Futebol")]
        Soccer,
        [Display(Name = "Basquete")]
        Basketball,
        [Display(Name = "Vôlei")]
        Volleyball,
        [Display(Name = "Luta")]
        Fight,
        [Display(Name = "Atletismo")]
        Athletics,
        [Display(Name = "eSports")]
        eSports,
        [Display(Name = "Nada")]
        Anything
    }
}