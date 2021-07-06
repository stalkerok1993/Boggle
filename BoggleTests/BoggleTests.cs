using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass()]
    public class BoggleTests
    {
        [TestMethod()]
        public void CheckTest()
        {
            var toCheck = new[] { "C", "EAR", "EARS", "BAILER", "ENLAREIAIBYORSCA", "CEREAL", "ROBES" };
            var expecteds = new[] { true, true, false, false, true, false, false };

            for (int i = 0; i < toCheck.Length; i++)
            {
                Assert.AreEqual(expecteds[i], new Boggle(CreateBoard(), toCheck[i]).Check(), $"\nWrong check for the word \"{toCheck[i]}\"");
            }
        }

        private char[][] CreateBoard()
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