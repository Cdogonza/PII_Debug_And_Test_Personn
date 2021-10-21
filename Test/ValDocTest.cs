using NUnit.Framework;
using Program;
namespace Test
{
    public class Tests
    {


        [Test]
        public void CedulaValidate()
        {
            string expected ="42668250";
            string cedula =  "266825d4";
            Person persona = new Person("Gonzalo Paz",cedula);
            Assert.AreEqual(expected,cedula);
        }
    }
}