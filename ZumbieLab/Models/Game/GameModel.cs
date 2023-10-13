using System.ComponentModel.DataAnnotations;

namespace ZumbieLab.Models
{
    public class GameModel
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Informe o nome do jogo")]
        public string Name { get; set; }
    }
}