using Xunit;
using Prime.Service;

namespace Prime.UnitTests.Service
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(candiadate: value);

            Assert.False(result, "{$value} should not be prime");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        [InlineData(19)]
        [InlineData(23)]
        [InlineData(29)]
        public void IsPrime_PrimesLessThan30_returnTrue(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, "{$value} should be prime)");
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(12)]
        [InlineData(14)]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(18)]
        [InlineData(20)]
        [InlineData(21)]
        [InlineData(22)]
        [InlineData(24)]
        [InlineData(26)]
        [InlineData(27)]
        [InlineData(28)]
        public void IsPrime_NonPrimesLessThan30_returnFalse(int value)
        {
            var result = _primeService.IsPrime(value);


            Assert.False(result, "{$value} should be prime)");
        }
    }

}