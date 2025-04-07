using Parcial1gvvc;

namespace Parcial1Test
{
    [TestClass]
    public sealed class TestUnitTriangulo
    {
        [TestMethod]
        public void TestArea()
        {
            double base_ = 1;
            double altura = 2;
            Triangulo triangulo = new Triangulo(base_, altura);
            double resultadoEsperado = 1;
            double resultado = triangulo.area();
            Assert.AreEqual(resultado, resultadoEsperado);
        }
        [TestMethod]
        public void TestPerimetro()
        {
            double base_ = 1;
            double altura = 2;
            Triangulo triangulo = new Triangulo(base_, altura);
            double resultadoEsperado = 5.23606797749979;
            double resultado = triangulo.perimetro();
            Assert.AreEqual(resultado, resultadoEsperado);
        }
    }
}
