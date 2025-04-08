using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Lib
{
	public abstract class figuraGeometrica
	{
		public abstract double area();
		public abstract double perimetro();

	}

	public class Triangulo : figuraGeometrica
	{
		private double lado;
		private double altura;

		public Triangulo(double lado, double altura)
		{
			this.lado = lado;
			this.altura = altura;
		}
		public override double area()
		{
			return (lado * altura) / 2;
		}

		public override double perimetro()
		{
			return lado * 3;
		}



	}

	public class Circulo : figuraGeometrica
	{

		private double radio;

		public Circulo(double radio)
		{
			this.radio = radio;
		}
		public override double area()
		{

			return (radio * radio) * Math.PI;

		}
		public override double perimetro()
		{
			return 2 * radio * Math.PI;
		}

	}



}
