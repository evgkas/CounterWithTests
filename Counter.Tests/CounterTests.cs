using CounterProject;
using Xunit;

namespace CounterTests
{
    public class CounterTests
    {
        private Counter counter = new();

        [Fact]
        public void DifferentSymbols_RandomString_ReturnCorrectValue()
        {
            string input = "123456aaa";
            int expectedCount = 7;

            int actualCount = counter.DifferentSymbols(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void DifferentSymbols_SymbolsInDifferentRegister_ReturnInputLength()
        {
            string input = "SsE";
            int expectedCount = 3;

            int actualCount = counter.DifferentSymbols(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void DifferentSymbols_IdenticalSymbols_ReturnOne()
        {
            string input = "sssssssssssssss";
            int expectedCount = 1;

            int actualCount = counter.DifferentSymbols(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void DifferentSymbols_UniqeSymbols_ReturnInputLength()
        {
            string input = "abcdEfG135";
            int expectedCount = input.Length;

            int actualCount = counter.DifferentSymbols(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void DifferentSymbols_EmptyString_ReturnZero()
        {
            string input = "";
            int expectedCount = 0;

            int actualCount = counter.DifferentSymbols(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalSymbols_RandomString_ReturnCorrectValue()
        {
            string input = "123aaa456rrrrrtyu";
            int expectedCount = 5;

            int actualCount = counter.IdenticalSymbols(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalSymbols_SymbolsInDifferentRegister_ReturnOne()
        {
            string input = "SsSsSs";
            int expectedCount = 1;

            int actualCount = counter.IdenticalSymbols(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalSymbols_EmptyString_ReturnZero()
        {
            string input = "";
            int expectedCount = 0;

            int actualCount = counter.IdenticalSymbols(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalSymbols_UniqeSymbols_ReturnOne()
        {
            string input = "qwertyuiopasdg";
            int expectedCount = 1;

            int actualCount = counter.IdenticalSymbols(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalSymbols_IdenticalSymbols_ReturnInputLenght()
        {
            string input = "ggggggggggggggggggg";
            int expectedCount = input.Length;

            int actualCount = counter.IdenticalSymbols(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalLetters_RandomString_ReturnCorrectValue()
        {
            string input = "123ab1b$bcdefg123";
            int expectedCount = 3;

            int actualCount = counter.IdenticalLetters(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalLetters_OnlyNumbers_ReturnZero()
        {
            string input = "123235346456";
            int expectedCount = 0;

            int actualCount = counter.IdenticalLetters(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalLetters_EmptyString_ReturnZero()
        {
            string input = "";
            int expectedCount = 0;

            int actualCount = counter.IdenticalLetters(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalLetters_IdenticalLetters_ReturnInputLength()
        {
            string input = "aaaaaaaa";
            int expectedCount = input.Length;

            int actualCount = counter.IdenticalLetters(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalLetters_SymbolsInDifferentRegisters_ReturnOne()
        {
            string input = "Aa";
            int expectedCount = 1;

            int actualCount = counter.IdenticalLetters(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalLetters_CyrrilicSymbols_ReturnZero()
        {
            string input = "АААБВГД";
            int expectedCount = 0;

            int actualCount = counter.IdenticalLetters(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalNumbers_RandomString_ReturnCorrectValue()
        {
            string input = "abfg112345555566";
            int expectedCount = 5;

            int actualCount = counter.IdenticalNumbers(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalNumbers_EmptyString_ReturnZero()
        {
            string input = "";
            int expectedCount = 0;

            int actualCount = counter.IdenticalNumbers(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalNumbers_NotNumbers_ReturnZero()
        {
            string input = "abasf$#f";
            int expectedCount = 0;

            int actualCount = counter.IdenticalNumbers(input);

            Assert.Equal(expectedCount, actualCount);
        }

        [Fact]
        public void IdenticalNumbers_IdenticalNumbers_ReturnInputLength()
        {
            string input = "1111111";
            int expectedCount = input.Length;

            int actualCount = counter.IdenticalNumbers(input);

            Assert.Equal(expectedCount, actualCount);
        }
    }
}