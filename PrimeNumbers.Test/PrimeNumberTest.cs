using PrimeNumbers.Core;
using Xunit;

namespace PrimeNumbers.Test
{
    public class PrimeNumberTest
    {
        private int[] _primeNumbers;

        public PrimeNumberTest()
        {
            _primeNumbers = new[] { 1, 2, 5, 23, 13,41 };
        }

        [Fact]
        public void OneIsPrimeNumber()
        {
            Assert.True(Prime.IsPrimeNumber(1));

        }

        [Fact]
        public void FourIsNotPrimeNumber()
        {
            Assert.False(Prime.IsPrimeNumber(4));

        }


        [Fact]
        public void NineIsNotPrimeNumber()
        {
            Assert.False(Prime.IsPrimeNumber(9));

        }



        [Fact]
        public void IsPrimeNumber()
        {
            foreach (var primeNumber in _primeNumbers)
            {
                Assert.True(Prime.IsPrimeNumber(primeNumber));
            }

        }


    }
}
