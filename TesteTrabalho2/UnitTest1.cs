using Trabalho2;
namespace TestTrabalho2;

[TestClass]
public class UnitTest1
{
    [TestClass]
    public class ExerciciosTests
    {
        [TestMethod]
        public void TestSomar()
        {
            Exercicios exercicios = new Exercicios();
            Assert.AreEqual(5, exercicios.Somar(2, 3));
        }

        [TestMethod]
        public void TestConverterMetrosParaMilimetros()
        {
            Exercicios exercicios = new Exercicios();
            Assert.AreEqual(5000, exercicios.ConverterMetrosParaMilimetros(5));
        }

        [TestMethod]
        public void TestPodeSeAposentar()
        {
            Exercicios exercicios = new Exercicios();
            Assert.IsTrue(exercicios.PodeSeAposentar(65, 30));
            Assert.IsTrue(exercicios.PodeSeAposentar(60, 25));
            Assert.IsFalse(exercicios.PodeSeAposentar(60, 24));
        }
    }
}