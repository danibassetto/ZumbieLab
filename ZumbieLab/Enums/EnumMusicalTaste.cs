using System.ComponentModel.DataAnnotations;

namespace ZumbieLab.Enums
{
    public enum EnumMusicalTaste
    {
        [Display(Name = "Pop")]
        Pop,
        [Display(Name = "Rock")]
        Rock,
        [Display(Name = "Pagode")]
        Pagode,
        [Display(Name = "Sertanejo")]
        Countryside,
        [Display(Name = "Hip-Hop/Rap")]
        HipHopRap,
        [Display(Name = "Eletrônica")]
        Electronics,
        [Display(Name = "Funk")]
        Funk,
        [Display(Name = "Metal")]
        Metal,
        [Display(Name = "Demais gêneros estranhos")]
        Other
    }
}