using NUnit.Framework;

namespace ProgramaNUnit
{
    public class Teste
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var result = false;

            Assert.IsFalse(result, "Teste 1 - recebe false");
            //Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            var result = 1 == 2;

            Assert.IsFalse(result, "Teste 2 - recebe false atraves de 1 == 2");
            //Assert.Pass();
        }


    }
}