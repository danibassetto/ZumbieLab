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
                    Force += 70;
                    Intelligence += 50;
                    Velocity += 80;
                    break;
                case EnumBloodType.ANegative:
                    Force += 60;
                    Intelligence += 40;
                    Velocity += 70;
                    break;
                case EnumBloodType.BPositive:
                    Force += 80;
                    Intelligence += 60;
                    Velocity += 85;
                    break;
                case EnumBloodType.BNegative:
                    Force += 70;
                    Intelligence += 50;
                    Velocity += 75;
                    break;
                case EnumBloodType.OPositive:
                    Force += 40;
                    Intelligence += 55;
                    Velocity += 60;
                    break;
                case EnumBloodType.ONegative:
                    Force += 30;
                    Intelligence += 45;
                    Velocity += 50;
                    break;
                case EnumBloodType.ABPositive:
                    Force += 100;
                    Intelligence += 100;
                    Velocity += 100;
                    break;
                case EnumBloodType.ABNegative:
                    Force += 90;
                    Intelligence += 90;
                    Velocity += 90;
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
                Force += 60;
                Intelligence += 50;
                Velocity += 70;
            }
            else if (Age >= 12 && Age <= 17)
            {
                Force += 90;
                Intelligence += 80;
                Velocity += 95;
            }
            else if (Age >= 18 && Age <= 29)
            {
                Force += 100;
                Intelligence += 100;
                Velocity += 100;
            }
            else if (Age >= 30 && Age <= 59)
            {
                Force += 90;
                Intelligence += 90;
                Velocity += 80;
            }
            else
            {
                Force += 70;
                Intelligence += 75;
                Velocity += 60;
            }
            #endregion

            #region MusicalTaste
            switch (MusicalTaste)
            {
                case EnumMusicalTaste.Pop:
                    Intelligence += 100;
                    break;
                case EnumMusicalTaste.Rock:
                    Intelligence += 70;
                    break;
                case EnumMusicalTaste.Pagode:
                    Intelligence += 40;
                    break;
                case EnumMusicalTaste.Countryside:
                    Intelligence += 60;
                    break;
                case EnumMusicalTaste.HipHopRap:
                    Intelligence += 70;
                    break;
                case EnumMusicalTaste.Electronics:
                    Intelligence += 90;
                    break;
                case EnumMusicalTaste.Funk:
                    Intelligence += 30;
                    break;
                case EnumMusicalTaste.Metal:
                    Intelligence += 50;
                    break;
                case EnumMusicalTaste.Other:
                    Intelligence += 10;
                    break;
            }
            #endregion

            #region Weight
            if (Weight >= 0 && Weight <= 30)
            {
                Force += 40;
                Velocity += 100;
            }
            else if (Weight > 31 && Weight <= 70)
            {
                Force += 70;
                Velocity += 80;
            }
            else
            {
                Force += 100;
                Velocity += 60;
            }
            #endregion

            #region Height
            if (Height >= 0 && Height <= 1)
            {
                Force += 60;
                Velocity += 50;
            }
            else if (Height > 1 && Height <= (decimal)1.5)
            {
                Force += 70;
                Velocity += 60;
            }
            else if (Height > (decimal)1.5 && Height <= 2)
            {
                Force += 90;
                Velocity += 80;

            }
            else
            {
                Force += 100;
                Velocity += 100;
            }
            #endregion

            #region Gender
            switch (Gender)
            {
                case EnumGender.F:
                    Force += 90;
                    Intelligence += 100;
                    Velocity += 85;
                    break;
                case EnumGender.M:
                    Force += 100;
                    Intelligence += 70;
                    Velocity += 100;
                    break;
            }
            #endregion

            #region FavoriteGame
            switch (FavoriteGame)
            {
                case EnumFavoriteGame.CounterStrike:
                    Intelligence += 90;
                    break;
                case EnumFavoriteGame.Minecraft:
                    Intelligence += 100;
                    break;
                case EnumFavoriteGame.Fortnite:
                    Intelligence += 70;
                    break;
                case EnumFavoriteGame.TheWitcher:
                    Intelligence += 100;
                    break;
                case EnumFavoriteGame.Valorant:
                    Intelligence += 60;
                    break;
                case EnumFavoriteGame.AssassinsCreed:
                    Intelligence += 90;
                    break;
                case EnumFavoriteGame.WorldOfWarcraft:
                    Intelligence += 80;
                    break;
                case EnumFavoriteGame.FIFA:
                    Intelligence += 50;
                    break;
                case EnumFavoriteGame.LeagueOfLegends:
                    Intelligence += 40;
                    break;
                case EnumFavoriteGame.Dota:
                    Intelligence += 60;
                    break;
                case EnumFavoriteGame.RocketLeague:
                    Intelligence += 30;
                    break;
                case EnumFavoriteGame.Other:
                    Intelligence += 10;
                    break;
            }
            #endregion

            #region SportPlayed
            switch(SportPlayed)
            {
                case EnumSportPlayed.Soccer:
                    Force += 90;
                    Intelligence += 60;
                    Velocity += 100;
                    break;
                case EnumSportPlayed.Basketball:
                    Force += 90;
                    Intelligence += 80;
                    Velocity += 100;
                    break;
                case EnumSportPlayed.Volleyball:
                    Force += 80;
                    Intelligence += 90;
                    Velocity += 70;
                    break;
                case EnumSportPlayed.Fight:
                    Force += 100;
                    Intelligence += 70;
                    Velocity += 50;
                    break;
                case EnumSportPlayed.Athletics:
                    Force += 90;
                    Intelligence += 80;
                    Velocity += 90;
                    break;
                case EnumSportPlayed.eSports:
                    Force += 30;
                    Intelligence += 100;
                    Velocity += 40;
                    break;
                case EnumSportPlayed.Anything:
                    Force += 0;
                    Intelligence += 0;
                    Velocity += 0;
                    break;
            }
            #endregion

            Force = Force / 6;
            Intelligence = Intelligence / 6;
            Velocity = Velocity / 6;
        }
    }
}