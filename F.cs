using System;

namespace ba
{
	class Program
	{
		public static void Main()
		{
			// Recebendo um número
			Console.WriteLine("Digite um número: ");
			double numero = double.Parse (Console.ReadLine());
			
			// Calculando raiz quadrada
			Console.WriteLine("Sua raiz quadrada é: " + Math.Sqrt(numero));  
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
