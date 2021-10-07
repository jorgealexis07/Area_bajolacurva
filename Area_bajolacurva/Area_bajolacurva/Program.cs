using System;

namespace Area_bajolacurva
{
	class MainClass
	{
		private double[] valoresC;
		private double[] nelm;
		private double x1;
		private double x2;
		private double Dx;
		private double n;
		private double sum=0;
		private double Area;

		public void Ingresar(){
			Console.WriteLine("Ingrese el valor de A");
			x1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el valor de B");
			x2 = double.Parse (Console.ReadLine());
			Console.WriteLine("Ingrese el valor de n");
			n = double.Parse (Console.ReadLine());
		}
		public void Deltax(){
			Dx = (x2 - x1) / n;
		}

		public void Cargar(){
			valoresC = new double[10];
			nelm = new double[10];
				for (int i = 0; i < 10; i++) {
				double x;
				x= i+1;
				nelm [i] = x;
				valoresC [i] = -Math.Pow ((x1 + (nelm [i] * Dx)), 2) + 6.5;
				}

		}

		public void Imprimir(){
			Console.Write ("El area bajo la curva \n");
			Console.Write ("Valores de C= f(x) \n");
			for (int i = 0; i < 10; i++) {
				Console.WriteLine(valoresC[i]);
			}

			for (int i = 0; i < 10; i++) {
				sum=sum+valoresC[i];
			}
			Console.WriteLine("La Suma C es= "+sum);
			Area = Dx * sum;
			Console.WriteLine("El Area bajo la curva = "+Area+" U^2");
			Console.ReadKey();

		}

		public static void Main (string[] args)
		{
			MainClass ab = new MainClass();
			ab.Ingresar ();
			ab.Deltax ();
			ab.Cargar ();
			ab.Imprimir ();

		}
	}
}
