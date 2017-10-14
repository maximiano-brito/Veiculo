using System;

namespace Veiculo
{
	abstract public class Veiculo
	{
		public String marca;
		public String modelo;
		public int ano;
		public Boolean temSeguro;
		public double quilometros;
		
		public Veiculo(){
			
		}
		
		public Veiculo(String ma, String mo, int an, Boolean ts, double km)
		{
			this.marca=ma;
			this.modelo=mo;
			this.ano=an;
			this.temSeguro=ts;
			this.quilometros=km;
		}
		
		public void seguroEmDia(){
			if(TemSeguro==true){
				Console.WriteLine("Seguro em dia.");
			}else{
				Console.WriteLine("Não tem seguro.");
			}
		}
		
		public void imprimirDados(){
			Console.WriteLine("-----Dados do Veiculo:-----");
			Console.WriteLine("Marca: " + Marca);
			Console.WriteLine("Modelo: " + Modelo);
			Console.WriteLine("Ano: " + Ano);
			seguroEmDia();
			Console.WriteLine("Quilómetros: " + Quilometros);
			Console.WriteLine("---------------------------\n");
		}
		
		
		public string Marca {
			get { return marca; }
			set { marca = value; }
		}

		public string Modelo {
			get { return modelo; }
			set { modelo = value; }
		}

		public int Ano {
			get { return ano; }
			set { ano = value; }
		}

		public bool TemSeguro {
			get { return temSeguro; }
			set { temSeguro = value; }
		}

		public double Quilometros {
			get { return quilometros; }
			set { quilometros = value; }
		}
		
	}
}
