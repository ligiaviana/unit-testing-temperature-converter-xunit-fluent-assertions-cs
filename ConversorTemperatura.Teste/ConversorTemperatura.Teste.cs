using FluentAssertions;

namespace ConversorTemperatura.Teste
{
    public class ConversorTemperaturaTeste
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(50, 10)]
        [InlineData(68, 20)]
        [InlineData(86, 30)]
        public void TesteConversorTemperatura(int fahrenheit, int celcius)
        {
            int resultado = ConversorTemperatura.FahrenheitParaCelcius(fahrenheit);
            resultado.Should().Be(celcius);
        }
    }
}