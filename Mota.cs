using System;

namespace Veiculo
{
	public class Mota : Veiculo
	{
		public Mota()
		{
		}
		
		public Mota(String ma, String mo, int an, Boolean ts, double km)
			: base(ma,mo,an,ts,km)
		{
		}
		
	}
}
