using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestFirstSprint2;
namespace TestFirstSprint2UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Pokemon p;
        List<string> MoveSet = new List<string>();
        [TestMethod]
        public void PokemonStat()
        {
            p = new Pokemon();
            
            string Name = "Pidgeot";
            string type = "Normal";
            string noise = "Kraaa";
            string special = "Fly";
            int heightFt = 4;
            int heightInch = 11;

            List<string> MoveSet = new List<string>();
            MoveSet.Add("Wing Attack");
            MoveSet.Add("Swift");
            MoveSet.Add("Quick Attack");
            MoveSet.Add("Gust");




            Assert.IsNotNull(p);
            Assert.AreEqual(p.pokeName, Name);
            Assert.AreEqual(p.type, type);
            Assert.AreEqual(p.noise, noise);
            Assert.AreEqual(p.specialMove, special);
            Assert.AreEqual(p.heightFt, heightFt);
            Assert.AreEqual(p.heightInch, heightInch);
        }

        [TestMethod]

        public void PokemonAbout()
        {
            p = new Pokemon();
            string Name = "Pidgeot";
            string type = "Normal";
            int heightFt = 4;
            int heightInch = 11;

            string About = string.Empty;
            About = $"{Name} is a {type} Pokemon and it is {heightFt} feet tall and {heightInch} inches.";

            Assert.AreEqual(p.About(), About);
        }

        [TestMethod]
        public void PokemonMoveSet()
        {
            p = new Pokemon();

            
            MoveSet.Add("Wing Attack");
            MoveSet.Add("Swift");
            MoveSet.Add("Quick Attack");
            MoveSet.Add("Gust");

            for(int i = 0; i < MoveSet.Count; i++)
            {
                Assert.AreEqual(p.MoveSet[i], MoveSet[i]);
            }
        }

        [TestMethod]
        public void PokemonGuard()
        {
            p = new Pokemon();

            string Name = "Pidgeot";
            string Guard = $"{Name} used Guard. Defense increased.";

            Assert.AreEqual(p.Guard(), Guard);
        }

        [TestMethod]
        public void PokemonMakeNoise()
        {
            p = new Pokemon();

            string Name = "Pidgeot";
            string noise = "Kraaa";
            string makeNoise = $"{Name} {noise}'s to you. It let you know you smell";

            Assert.AreEqual(p.MakeNoise(), makeNoise);
        }
        [TestMethod]
        public void PokemonSpecialMove()
        {
            p = new Pokemon();

            string Name = "Pidgeot";
            string specialMove = "Fly";
            string useSpecial = $"{Name} uses their special move {specialMove}.";

            Assert.AreEqual(p.SpecialMove(), useSpecial);
        }
    }
}
