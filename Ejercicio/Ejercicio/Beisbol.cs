using System;
using System.Collections.Generic;

namespace EjFormu05
{
	public class Beisbol
	{
		private List<Baseball> _Bate;
		public List<Baseball> Bate {get {return _Bate;} set {_Bate = value;}}
		
		public Beisbol()
		{
			Bate = new List<Baseball>();
		}
		
		public void Registrar(Baseball x)
		{
			Bate.Add(x);
		}
		
		public Boolean Buscar(String n)
		{
			Boolean x = false;
			Int16 w = 0;
			while ((w < Bate.Count) && (!x))
			{
				if (Bate[w].Nombre == n) x = true;
				w++;
			}
			return x;
		}

		public Baseball Consultar(String n)
		{
			Baseball u = new Baseball();
			Boolean x = false;
			Int16 w = 0;
			while ((w < Bate.Count) && (!x))
			{
				if (Bate[w].Nombre == n) x = true;
				   else w++;
			}
			if (x == true) u = Bate[w];
			return u;
		}
		
		public void Actualizar(Baseball x)
		{
			Int16 w = 0;
			while (w < Bate.Count)
			{
				if (Bate[w].Nombre == x.Nombre) 
				{
					Bate[w].NombreCiudad = x.NombreCiudad;
					Bate[w].Liga = x.Liga;
					Bate[w].JuegosPerdidos = x.JuegosPerdidos;
					Bate[w].JuegosGanados = x.JuegosGanados;

					break;
				} else w++;
			}
		}
	}
}
