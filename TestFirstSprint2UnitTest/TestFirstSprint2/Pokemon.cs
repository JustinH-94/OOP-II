using System;
using System.Collections.Generic;
using System.Text;

namespace TestFirstSprint2
{
    public class Pokemon
    {
        public string pokeName;
        public string type;
        public string noise;
        public string specialMove;
        public int heightFt;
        public int heightInch;

        public List<string> MoveSet = new List<string>();
        public Pokemon()
        {
            pokeName = "Pidgeot";
            type = "Normal";
            noise = "Kraaa";
            specialMove = "Fly";
            heightFt = 4;
            heightInch = 11;
            MoveSet.Add("Wing Attack");
            MoveSet.Add("Swift");
            MoveSet.Add("Quick Attack");
            MoveSet.Add("Gust");
        }

        public string Attack(string move)
        {
            return $"{pokeName} used {move}.";
        }

        public string Guard()
        {
            return $"{pokeName} used Guard. Defense increased.";
        }

        public string MakeNoise()
        {
            return $"{pokeName} {noise}'s to you. It let you know you smell";
        }

        public string About()
        {
            return $"{pokeName} is a {type} Pokemon and it is {heightFt} feet tall and {heightInch} inches.";
        }

        public string SpecialMove()
        {
            return $"{pokeName} uses their special move {specialMove}.";
        }
    }
}
