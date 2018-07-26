using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_5
{
	class Program
	{
		static void Main(string[] args)
		{
			int numero1, numero2, Resultado;
			Console.WriteLine("Ingrese primer numero");
			numero1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Ingrese segundo numero");
			numero2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("El resultado del producto es:" + (numero1 * numero2));
		
			Console.ReadKey();


		}
	}
}
