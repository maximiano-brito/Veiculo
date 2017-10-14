using System;

namespace Veiculo
{
	public class Carro : Veiculo
	{
		public Carro()
		{
		}
		
		public Carro(String ma, String mo, int an, Boolean ts, double km)
			: base(ma,mo,an,ts,km)
		{
		}
		
	}
}
