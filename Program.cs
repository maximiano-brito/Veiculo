using System;

namespace Veiculo
{
	class Program
	{
		public static void Main(string[] args)
		{
			Carro c1 = new Carro("Fiat","Uno",1994, true, 150000);
			Carro c2 = new Carro("Porche","Panamera", 2013,false, 120000);
			
			c1.imprimirDados();
			c2.imprimirDados();
		
			Mota m1 = new Mota("Yamaha","Raptor 700 R", 2009 ,true, 12000);
			
			m1.imprimirDados();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
		}
	}
}