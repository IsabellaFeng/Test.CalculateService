using CalculationService;
using System.Diagnostics.CodeAnalysis;
using FluentAssertions;

namespace Test.CalculateService
{
    public class SalaryCalculateServiceTests
    {

        private readonly SalaryCalculateService _salaryCalculateService;

        public SalaryCalculateServiceTests()
        {
            _salaryCalculateService = new SalaryCalculateService();
        }

        [Fact]
        public void TestCalculateTaxForBandsFor0Salary()
        {

            var mockBandsList = new List<TaxRateBand>()
        {
            new TaxRateBand { BandStart = 0.00m, BandFinish = 10000.00m, TaxRatePercentage = 5.5m },
            new TaxRateBand { BandStart = 10000.00m, BandFinish = 20000.00m, TaxRatePercentage = 10.0m },
            new TaxRateBand { BandStart = 20000.00m, BandFinish = 30000.00m, TaxRatePercentage = 20.0m },
            new TaxRateBand { BandStart = 30000.00m, BandFinish = 0.00m, TaxRatePercentage = 30.0m }
        };

            var expectedBandsListFor0 = new List<TaxRateBand>()
        {
            new TaxRateBand { BandStart = 0.00m, BandFinish = 10000.00m, TaxRatePercentage = 5.5m, TaxCollected = 0.00m },
            new TaxRateBand { BandStart = 10000.00m, BandFinish = 20000.00m, TaxRatePercentage = 10.0m, TaxCollected = 0.00m },
            new TaxRateBand { BandStart = 20000.00m, BandFinish = 30000.00m, TaxRatePercentage = 20.0m, TaxCollected = 0.00m },
            new TaxRateBand { BandStart = 30000.00m, BandFinish = 0.00m, TaxRatePercentage = 30.0m, TaxCollected = 0.00m }
        };


            _salaryCalculateService.CalculateTaxForBands(mockBandsList, 0);
            mockBandsList.Should().BeEquivalentTo(expectedBandsListFor0);

        }

        [Fact]
        public void TestCalculateTaxForBandsFor9000Salary()
        {
            var mockBandsList = new List<TaxRateBand>()
        {
            new TaxRateBand { BandStart = 0.00m, BandFinish = 10000.00m, TaxRatePercentage = 5.5m },
            new TaxRateBand { BandStart = 10000.00m, BandFinish = 20000.00m, TaxRatePercentage = 10.0m },
            new TaxRateBand { BandStart = 20000.00m, BandFinish = 30000.00m, TaxRatePercentage = 20.0m },
            new TaxRateBand { BandStart = 30000.00m, BandFinish = 0.00m, TaxRatePercentage = 30.0m }
        };

            var expectedBandsListFor9000 = new List<TaxRateBand>()
       {
            new TaxRateBand { BandStart = 0.00m, BandFinish = 10000.00m, TaxRatePercentage = 5.5m, TaxCollected = 495.00m },
            new TaxRateBand { BandStart = 10000.00m, BandFinish = 20000.00m, TaxRatePercentage = 10.0m, TaxCollected = 0.00m },
            new TaxRateBand { BandStart = 20000.00m, BandFinish = 30000.00m, TaxRatePercentage = 20.0m, TaxCollected = 0.00m },
            new TaxRateBand { BandStart = 30000.00m, BandFinish = 0.00m, TaxRatePercentage = 30.0m, TaxCollected = 0.00m }
        };
            _salaryCalculateService.CalculateTaxForBands(mockBandsList, 9000);
            mockBandsList.Should().BeEquivalentTo(expectedBandsListFor9000);
        }

        [Fact]
        public void TestCalculateTaxForBandsFor25000Salary()
        {
            var mockBandsList = new List<TaxRateBand>()
        {
            new TaxRateBand { BandStart = 0.00m, BandFinish = 10000.00m, TaxRatePercentage = 5.5m },
            new TaxRateBand { BandStart = 10000.00m, BandFinish = 20000.00m, TaxRatePercentage = 10.0m },
            new TaxRateBand { BandStart = 20000.00m, BandFinish = 30000.00m, TaxRatePercentage = 20.0m },
            new TaxRateBand { BandStart = 30000.00m, BandFinish = 0.00m, TaxRatePercentage = 30.0m }
        };

            var expectedBandsListFor25000 = new List<TaxRateBand>()
        {
            new TaxRateBand { BandStart = 0.00m, BandFinish = 10000.00m, TaxRatePercentage = 5.5m, TaxCollected = 550.00m },
            new TaxRateBand { BandStart = 10000.00m, BandFinish = 20000.00m, TaxRatePercentage = 10.0m, TaxCollected = 1000.00m },
            new TaxRateBand { BandStart = 20000.00m, BandFinish = 30000.00m, TaxRatePercentage = 20.0m, TaxCollected = 1000.00m },
            new TaxRateBand { BandStart = 30000.00m, BandFinish = 0.00m, TaxRatePercentage = 30.0m, TaxCollected = 0.00m }
        };
            _salaryCalculateService.CalculateTaxForBands(mockBandsList, 25000);
            mockBandsList.Should().BeEquivalentTo(expectedBandsListFor25000);
        }

        [Fact]
        public void TestCalculateTaxForBandsFor40000Salary()
        {
            var mockBandsList = new List<TaxRateBand>()
        {
            new TaxRateBand { BandStart = 0.00m, BandFinish = 10000.00m, TaxRatePercentage = 5.5m },
            new TaxRateBand { BandStart = 10000.00m, BandFinish = 20000.00m, TaxRatePercentage = 10.0m },
            new TaxRateBand { BandStart = 20000.00m, BandFinish = 30000.00m, TaxRatePercentage = 20.0m },
            new TaxRateBand { BandStart = 30000.00m, BandFinish = 0.00m, TaxRatePercentage = 30.0m }
        };

            var expectedBandsListFor40000 = new List<TaxRateBand>()
        {
           new TaxRateBand { BandStart = 0.00m, BandFinish = 10000.00m, TaxRatePercentage = 5.5m, TaxCollected = 550.00m },
            new TaxRateBand { BandStart = 10000.00m, BandFinish = 20000.00m, TaxRatePercentage = 10.0m, TaxCollected = 1000.00m },
            new TaxRateBand { BandStart = 20000.00m, BandFinish = 30000.00m, TaxRatePercentage = 20.0m, TaxCollected = 2000.00m },
            new TaxRateBand { BandStart = 30000.00m, BandFinish = 0.00m, TaxRatePercentage = 30.0m, TaxCollected = 3000.00m }
        };
            _salaryCalculateService.CalculateTaxForBands(mockBandsList, 40000);
            mockBandsList.Should().BeEquivalentTo(expectedBandsListFor40000);
        }

        [Fact]
        public void TestCalculateTotalTaxCollected()
        {
            var expectedBandsListFor0 = new List<TaxRateBand>()
        {
            new TaxRateBand { BandStart = 0.00m, BandFinish = 10000.00m, TaxRatePercentage = 5.5m, TaxCollected = 0.00m },
            new TaxRateBand { BandStart = 10000.00m, BandFinish = 20000.00m, TaxRatePercentage = 10.0m, TaxCollected = 0.00m },
            new TaxRateBand { BandStart = 20000.00m, BandFinish = 30000.00m, TaxRatePercentage = 20.0m, TaxCollected = 0.00m },
            new TaxRateBand { BandStart = 30000.00m, BandFinish = 0.00m, TaxRatePercentage = 30.0m, TaxCollected = 0.00m }
        };

            var expectedBandsListFor40000 = new List<TaxRateBand>()
        {
           new TaxRateBand { BandStart = 0.00m, BandFinish = 10000.00m, TaxRatePercentage = 5.5m, TaxCollected = 550.00m },
            new TaxRateBand { BandStart = 10000.00m, BandFinish = 20000.00m, TaxRatePercentage = 10.0m, TaxCollected = 1000.00m },
            new TaxRateBand { BandStart = 20000.00m, BandFinish = 30000.00m, TaxRatePercentage = 20.0m, TaxCollected = 2000.00m },
            new TaxRateBand { BandStart = 30000.00m, BandFinish = 0.00m, TaxRatePercentage = 30.0m, TaxCollected = 3000.00m }
        };

            var totalTaxFor0 = _salaryCalculateService.CalculateTotalTaxCollected(expectedBandsListFor0);
            var totalTaxFor40000 = _salaryCalculateService.CalculateTotalTaxCollected(expectedBandsListFor40000);
            Assert.Equal(0, totalTaxFor0);
            Assert.Equal(6550, totalTaxFor40000);
        }

        [Fact]
        public void TestCalculateTotalTaxCollectedWithGivenData()
        {
            var bandsList = _salaryCalculateService.GetInitialRateBand();
            _salaryCalculateService.CalculateTaxForBands(bandsList, 80000);
            var expectedTotal = _salaryCalculateService.CalculateTotalTaxCollected(bandsList);
            Assert.Equal(19230, expectedTotal);
        }
    }
}