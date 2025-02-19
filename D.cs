using System;

namespace ATIVIDADE_4
{
	class Program
	{
		public static void Main()
		{
			// Recebendo número do úsuario
			Console.WriteLine("Digite um número: ");
			int numero = int.Parse(Console.ReadLine());
			
			// Calculando quadrado do número do úsuario
			int numeroQuadrado = numero * numero;
			
			// Exibindo número do úsuario
			Console.WriteLine("O quadrado do seu número é: " + numeroQuadrado);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
