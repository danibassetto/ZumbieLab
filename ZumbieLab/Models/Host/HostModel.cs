using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZombieLab.Enums;

namespace ZombieLab.Models
{
    public class HostModel
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Informe a idade")]
        [Range(1, int.MaxValue, ErrorMessage = "A idade deve ser maior que zero!")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Informe o sexo")]
        public EnumGender? Gender { get; set; }
        [Required(ErrorMessage = "Informe o peso")]
        [Column(TypeName = "decimal(5,2)")]
        [Range(1, int.MaxValue, ErrorMessage = "O peso deve ser maior que zero!")]
        public decimal? Weight { get; set; }
        [Required(ErrorMessage = "Informe a altura")]
        [Column(TypeName = "decimal(4,2)")]
        [Range(1, int.MaxValue, ErrorMessage = "A altura deve ser maior que zero!")]
        public decimal Height { get; set; }
        [Required(ErrorMessage = "Informe o tipo sanguíneo")]
        public EnumBloodType? BloodType { get; set; }
        [Required(ErrorMessage = "Informe o gosto musical")]
        public EnumMusicalTaste? MusicalTaste { get; set; }
        [Required(ErrorMessage = "Informe o esporte praticado")]
        public EnumSportPlayed? SportPlayed { get; set; }
        [Required(ErrorMessage = "Informe o jogo preferido")]
        public EnumFavoriteGame? FavoriteGame { get; set; }
    }
}