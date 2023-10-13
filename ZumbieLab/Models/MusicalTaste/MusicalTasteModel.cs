﻿using System.ComponentModel.DataAnnotations;

namespace ZumbieLab.Models
{
    public class MusicalTasteModel
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Informe a descrição")]
        public string Description { get; set; }
    }
}