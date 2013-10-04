using System;

namespace Practica4
{
	public class Persona
	{
		public string codigo;
		public string nombre;
		public string telefono;
		public string facebook;
		
		public void imprimePersona(Persona n){
			Console.WriteLine("\tCódigo: " + n.codigo);
			Console.WriteLine("\tNombre: " + n.nombre);
			Console.WriteLine("\tTelefono: " + n.telefono);
			Console.WriteLine("\tFacebook: " + n.facebook);
			Console.WriteLine(" ");
		}
	}
}

