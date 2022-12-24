using SimpleAPI.Controllers;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController weather = new WeatherForecastController();

        [Fact]
        public void SummaryAtIndexOneIsBracing()
        {
            WeatherForecast value = weather.GetOne(1);

            Assert.NotNull(value);
            Assert.Equal(value.Summary, "BracingWrong");
        }
    }
}
