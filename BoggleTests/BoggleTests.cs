using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass()]
    public class BoggleTests
    {
        [TestMethod()]
        public void CheckDefinitionTest()
        {
            var toCheck = new[] { "GEO", "BIAS", "ILNBIA", "BUNGIE", "BINS", "SINUS" };
            var expecteds = new[] { true, true, true, false, false, false };

            for (int i = 0; i < toCheck.Length; i++)
            {
                Assert.AreEqual(expecteds[i], new Boggle(CreateBoard1(), toCheck[i]).Check(), $"\nWrong check for the word \"{toCheck[i]}\"");
            }
        }

        [TestMethod()]
        public void CheckTest()
        {
            var toCheck = new[] { "C", "EAR", "EARS", "BAILER", "ENLAREIAIBYORSCA", "CEREAL", "ROBES" };
            var expecteds = new[] { true, true, false, false, true, false, false };

            for (int i = 0; i < toCheck.Length; i++)
            {
                Assert.AreEqual(expecteds[i], new Boggle(CreateBoard2(), toCheck[i]).Check(), $"\nWrong check for the word \"{toCheck[i]}\"");
            }
        }
        private char[][] CreateBoard1()
        {
            return new char[][]
            {
                new[] { 'I', 'L', 'A', 'W' },
                new[] { 'B', 'N', 'G', 'E' },
                new[] { 'I', 'U', 'A', 'O' },
                new[] { 'A', 'S', 'R', 'L' }
            };
        }

        private char[][] CreateBoard2()
        {
            return new char[][]
            {
                new[] { 'E', 'A', 'R', 'A' },
                new[] { 'N', 'L', 'E', 'C' },
                new[] { 'I', 'A', 'I', 'S' },
                new[] { 'B', 'Y', 'O', 'R' }
            };
        }
    }
}