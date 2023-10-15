using Microsoft.Net.Http.Headers;
using Pomelo.EntityFrameworkCore.MySql.Query.ExpressionTranslators.Internal;
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
        public int? Force { get; set; }
        public int? Intelligence { get; set; }
        public int? Velocity { get; set; }

        public void SetAttributes()
        {
            Force = 0;
            Intelligence = 0;
            Velocity = 0;

            #region BloodType
            switch (BloodType)
            {
                case EnumBloodType.APositive:
                    Force += 165;
                    Intelligence += 120;
                    Velocity += 160;
                    break;
                case EnumBloodType.ANegative:
                    Force += 155;
                    Intelligence += 110;
                    Velocity += 150;
                    break;
                case EnumBloodType.BPositive:
                    Force += 180;
                    Intelligence += 135;
                    Velocity += 140;
                    break;
                case EnumBloodType.BNegative:
                    Force += 170;
                    Intelligence += 125;
                    Velocity += 130;
                    break;
                case EnumBloodType.OPositive:
                    Force += 70;
                    Intelligence += 65;
                    Velocity += 90;
                    break;
                case EnumBloodType.ONegative:
                    Force += 60;
                    Intelligence += 55;
                    Velocity += 80;
                    break;
                case EnumBloodType.ABPositive:
                    Force += 200;
                    Intelligence += 200;
                    Velocity += 200;
                    break;
                case EnumBloodType.ABNegative:
                    Force += 190;
                    Intelligence += 190;
                    Velocity += 190;
                    break;
            }
            #endregion

            #region Age
            if (Age >= 0 && Age <= 5)
            {
                Force += 20;
                Intelligence += 35;
                Velocity += 40;
            }
            else if (Age >= 6 && Age <= 11)
            {
                Force += 80;
                Intelligence += 70;
                Velocity += 110;
            }
            else if (Age >= 12 && Age <= 17)
            {
                Force += 110;
                Intelligence += 90;
                Velocity += 100;
            }
            else if (Age >= 18 && Age <= 29)
            {
                Force += 200;
                Intelligence += 200;
                Velocity += 200;
            }
            else if (Age >= 30 && Age <= 59)
            {
                Force += 190;
                Intelligence += 190;
                Velocity += 150;
            }
            else
            {
                Force += 170;
                Intelligence += 140;
                Velocity += 60;
            }
            #endregion

            #region MusicalTaste
            switch (MusicalTaste)
            {
                case EnumMusicalTaste.Pop:
                    Intelligence += 200;
                    break;
                case EnumMusicalTaste.Rock:
                    Intelligence += 160;
                    break;
                case EnumMusicalTaste.Pagode:
                    Intelligence += 70;
                    break;
                case EnumMusicalTaste.Countryside:
                    Intelligence += 120;
                    break;
                case EnumMusicalTaste.HipHopRap:
                    Intelligence += 110;
                    break;
                case EnumMusicalTaste.Electronics:
                    Intelligence += 180;
                    break;
                case EnumMusicalTaste.Funk:
                    Intelligence += 50;
                    break;
                case EnumMusicalTaste.Metal:
                    Intelligence += 80;
                    break;
                case EnumMusicalTaste.Other:
                    Intelligence += 30;
                    break;
            }
            #endregion

            #region Weight
            if (Weight >= 0 && Weight <= 30)
            {
                Force += 70;
                Velocity += 200;
            }
            else if(Weight > 31 && Weight <= 70)
            {
                Force += 140;
                Velocity += 160;
            }
            else
            {
                Force += 200;
                Velocity += 80;
            }
            #endregion

            #region Height
            if (Height >= 0 && Height <= 1)
            {
                Force += 50;
                Velocity += 70;
            }
            else if(Height > 1  && Height <= (decimal)1.5)
            {
                Force += 80;
                Velocity += 100;
            }
            else if (Height > (decimal)1.5 && Height <= 2)
            {
                Force += 160;
                Velocity += 140;

            }
            else
            {
                Force += 200;
                Velocity += 200;
            }
            #endregion

            #region Gender
            switch (Gender)
            {
                case EnumGender.F:
                    Force += 180;
                    Intelligence += 200;
                    Velocity += 190;
                    break;
                case EnumGender.M:
                    Force += 200;
                    Intelligence += 170;
                    Velocity += 200;
                    break;
            }
            #endregion

            #region FavoriteGame
            switch (FavoriteGame)
            {
                case EnumFavoriteGame.CounterStrike:
                    Intelligence += 190;
                    break;
                case EnumFavoriteGame.Minecraft:
                    Intelligence += 200;
                    break;
                case EnumFavoriteGame.Fortnite:
                    Intelligence += 80;
                    break;
                case EnumFavoriteGame.TheWitcher:
                    Intelligence += 200;
                    break;
                case EnumFavoriteGame.Valorant:
                    Intelligence += 120;
                    break;
                case EnumFavoriteGame.AssassinsCreed:
                    Intelligence += 150;
                    break;
                case EnumFavoriteGame.WorldOfWarcraft:
                    Intelligence += 90;
                    break;
                case EnumFavoriteGame.FIFA:
                    Intelligence += 60;
                    break;
                case EnumFavoriteGame.LeagueOfLegends:
                    Intelligence += 50;
                    break;
                case EnumFavoriteGame.Dota:
                    Intelligence += 90;
                    break;
                case EnumFavoriteGame.RocketLeague:
                    Intelligence += 70;
                    break;
                case EnumFavoriteGame.Other:
                    Intelligence += 30;
                    break;
            }
            #endregion
        }
    }
}