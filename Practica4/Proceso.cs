using System;
using System.Collections;

namespace Practica4{
	public class Proceso{
		public Hashtable tabla;
		public Proceso (){
			this.tabla = new Hashtable();	
		}
		public void capturar(){
			for (int i=1; i<5; i++){
				Persona p=new Persona();
				Console.Clear();
				Console.WriteLine("\t\t\tIntroducir Datos: " + i +" de 4");
				Console.WriteLine("Introdusca su Código");
				p.codigo = Console.ReadLine();
				Console.WriteLine("Introdusca su Nombre: ");
				p.nombre = Console.ReadLine();
				Console.WriteLine("Introdusca su Telefono: ");
				p.telefono = Console.ReadLine();
				Console.WriteLine("Introdusca su Facebook: ");
				p.facebook = Console.ReadLine();
				this.tabla.Add(p.codigo, p);
				try{
	               tabla.Add(p.codigo, p);
	               p.imprimePersona(p);
	            }catch{
				  Console.WriteLine("La llave ya " + p.codigo + " existe");
	            }
            }
			for (int i = 1; i < 3; i++){
                Console.Clear();
                Console.WriteLine("\t\t\tIntroducir Codigo a modificar: " + i +" de 2\n");
                string k = Console.ReadLine();
                try{
                    if (tabla.ContainsKey(k)){
                        Persona a = (Persona) tabla[k];
                        a.imprimePersona(a);
                        tabla.Remove(k);
                        Console.WriteLine("Introdusca Nombre:");
                        a.nombre = Console.ReadLine();
                        Console.WriteLine("Introdusca Telefono: ");
                        a.telefono = Console.ReadLine();
                        Console.WriteLine("Introdusca su Facebook: ");
                        a.facebook = Console.ReadLine();
                        tabla.Add(a.codigo, a);
                    }
                }catch{
                    Console.WriteLine("El codigo " + k + " no existe");
                }
            }
			for (int i = 1; i < 3; i++){
                Console.Clear();
                Console.WriteLine("\t\t\tIngresar Codigo para Eliminar: " + i +" de 2\n");
                string k = Console.ReadLine();
                try{
                    if (tabla.ContainsKey(k)){
                        Console.WriteLine("Esta seguro de eliminar el Codigo " + k + "?\n");
						Console.WriteLine("\t8 - Sí, 9 - No");
                        int r = int.Parse(Console.ReadLine());
                        if (r == 8)
                            tabla.Remove(k);
                        else{
                            Console.Clear();
                        }    
                    }
                }
                catch{
                    Console.WriteLine("El codigo >" + k + " no existe");
                }
            }
			Console.Clear();
            Console.WriteLine("\t\t\tDatos Restantes");
            ICollection pers = tabla.Values;
	        Console.WriteLine();
	        foreach( object objeto in pers ){
	            Persona p = (Persona) objeto;
				p.imprimePersona(p);
	        }
            Console.ReadKey(true);
		}
	}
}

