using System.ComponentModel.DataAnnotations;
using ZumbieLab.Enums;

namespace ZumbieLab.Models
{
    public class HostModel
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Informe a idade")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Informe o sexo")]
        public EnumGender Gender { get; set; }
        [Required(ErrorMessage = "Informe o peso")]
        public decimal Weight { get; set; }
        [Required(ErrorMessage = "Informe a altura")]
        public decimal Height { get; set; }
        [Required(ErrorMessage = "Informe o tipo sanguíneo")]
        public EnumBloodType BloodType { get; set; }
        [Required(ErrorMessage = "Informe o gosto musical")]
        public EnumMusicalTaste MusicalTaste { get; set; }
        [Required(ErrorMessage = "Informe o esporte praticado")]
        public EnumSportPlayed SportPlayed { get; set; }
        [Required(ErrorMessage = "Informe o jogo preferido")]
        public EnumFavoriteGame FavoriteGame { get; set; }
    }
}