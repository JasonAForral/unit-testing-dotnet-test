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

        [Fact]
        public void PrimeService_IsPrimeShould_ReturnFalse()
        {
            var result = _primeService.isPrime(1);

            Assert.False(result, "1 should not be prime");
        }
    }
}