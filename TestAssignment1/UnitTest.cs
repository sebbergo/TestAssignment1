using NUnit.Framework;

namespace TestAssignment1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FahrenheitToCelsiusTest()
        {
            //ARRANGE
            Converter converter = new Converter();

            //ACT
            double celsius = converter.FahrenheitToCelsius(40);

            //ASSERT
            Assert.That(celsius, Is.EqualTo(4.4).Within(0.05));
        }

        [Test]
        public void CelsiusToFahrenheit()
        {
            //ARRANGE
            Converter converter = new Converter();

            //ACT
            double fahrenheit = converter.CelsiusToFahrenheit(20);

            //ASSERT
            Assert.That(fahrenheit, Is.EqualTo(68).Within(0.05));
        }

        [Test]
        public void ArabicToRoman()
        {
            //ARRANGE
            Converter converter = new Converter();

            //ACT
            string RomanResult = converter.ArabicToRoman(159);

            //ASSERT
            Assert.That(RomanResult, Is.EqualTo("CLIX"));
        }
    }
}