using System;

namespace TableDe5
{
	class Program
	{
		static void Main(string[] args)
		{

			int nombre;
			int resultat;
			int n;

			nombre = 0;
			for (int n = 1; n <= 100; n + 1)
			{
				resultat = n * 5;
				nombre = nombre + "," + resultat;
			}
				Console.WriteLine(nombre));
		}

	}
}
