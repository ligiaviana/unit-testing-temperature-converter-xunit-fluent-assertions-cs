namespace ConversorTemperatura
{
    public static class ConversorTemperatura
    {
        public static int FahrenheitParaCelcius(int fahrenheit)
        {
            return (int)((fahrenheit - 32) / 1.8);
        }

    }
}