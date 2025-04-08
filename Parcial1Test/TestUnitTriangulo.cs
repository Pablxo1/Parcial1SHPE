using Parcial1Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Test
{
    [TestClass]
    public sealed class TestUnitTriangulo
    {
		[TestMethod]
		public void TrianguloArea()
		{
			Triangulo triangulo = new Triangulo(3, 4);
			double resultado = triangulo.area();
			Assert.AreEqual(6, resultado);
		}

		[TestMethod]
		public void TrianguloPerimetro()
		{
			Triangulo triangulo2 = new Triangulo(2,0);
			double resultado2 = triangulo2.perimetro();
			Assert.AreEqual(6, resultado2);
		}


	}
}
