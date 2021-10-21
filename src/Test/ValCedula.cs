using NUnit.Framework;
using Program;
namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [ValCedula]
        public void TestCedula()
        {
            Person persona = new Person("Gonzalo Paz","4.266.825-0");
            persona.IntroduceYourself();
            Assert.Pass();
        }
    }
}