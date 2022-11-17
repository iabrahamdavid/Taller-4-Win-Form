using System;
using System.Collections.Generic;

namespace EjFormu05
{
	public class Baseball
	{
		private String _nombre;
		private String _nombreCiudad;
		private Boolean _liga;
		private String _juegosPerdidos;
		private String _juegosGanados;


		public String Nombre {get {return _nombre;} set {_nombre = value;}}
		public String NombreCiudad { get { return _nombreCiudad; } set { _nombreCiudad = value; } }
		public Boolean Liga {get {return _liga;} set {_liga = value;}}
		public String JuegosPerdidos { get { return _juegosPerdidos; } set { _juegosPerdidos = value; } }
		public String JuegosGanados { get { return _juegosGanados; } set { _juegosGanados = value; } }

		public Baseball()
		{
			Nombre = ""; Liga = true;
			NombreCiudad = ""; JuegosGanados = ""; JuegosPerdidos = "";
		}
		
		public Baseball(String n, String s , Boolean x, String v, String z)
		{
			Nombre = n; NombreCiudad = s; Liga = x; JuegosPerdidos= v; JuegosGanados = z;
	}
}
	}
