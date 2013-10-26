using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class Program
    {
        public Int64 codigo1, codigo2, codigo3, codigo4;
        public string nombre1, nombre2, nombre3, nombre4;
        public Int64 telefono1, telefono2, telefono3, telefono4;
        public string face1, face2, face3, face4, s;
		
		
        static void Main(string[] args)
        {
            Program c = new Program();
                
            {

                Console.WriteLine("=========================  CAPTURAS  ===========================\n\n");
                Console.WriteLine("Ingresa el Codigo #1\n");
                c.codigo1 = Int64.Parse(Console.ReadLine());
                
                
                Console.WriteLine("\nDame el Nombre #1\n");
                c.nombre1 = Console.ReadLine();

                Console.WriteLine("\nIngresa el Telefono #1\n");
                c.telefono1 = Int64.Parse(Console.ReadLine());

                Console.WriteLine("\nDame el Facebook #1\n");
                c.face1 = Console.ReadLine();
                Console.Clear();
				
 				Console.WriteLine("=========================  CAPTURAS  ===========================\n\n");
                Console.WriteLine("\nIngresa el Codigo #2\n");
                c.codigo2 = Int64.Parse(Console.ReadLine());

                Console.WriteLine("\nDame el Nombre #2\n");
                c.nombre2 = Console.ReadLine();

                Console.WriteLine("\nIngresa el Telefono #2\n");
                c.telefono2 = Int64.Parse(Console.ReadLine());

                Console.WriteLine("\nDame el Facebook #2\n");
                c.face2 = Console.ReadLine();
                Console.Clear();
            
                Console.WriteLine("=========================  CAPTURAS  ===========================\n\n");
                Console.WriteLine("\nIngresa el Codigo #3\n");
                c.codigo3 = Int64.Parse(Console.ReadLine());

                Console.WriteLine("\nDame el Nombre #3\n");
                c.nombre3 = Console.ReadLine();

                Console.WriteLine("\nIngresa el Telefono #3\n");
                c.telefono3 = Int64.Parse(Console.ReadLine());

                Console.WriteLine("\nDame el Facebook #3\n");
                c.face3 = Console.ReadLine();
                Console.Clear();
				
                
                Console.WriteLine("=========================  CAPTURAS  ===========================\n\n");
                Console.WriteLine("\nIngresa el Codigo #4\n");
                c.codigo4 = Int64.Parse(Console.ReadLine());

                Console.WriteLine("\nDame el Nombre #4\n");
                c.nombre4 = Console.ReadLine();

                Console.WriteLine("\nIngresa el Telefono #4\n");
                c.telefono4 = Int64.Parse(Console.ReadLine());

                Console.WriteLine("\nDame el Facebook #4\n");
                c.face4 = Console.ReadLine();
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("=========================  EDICION  ===========================\n\n");
            
            for(int x = 1; x < 3; x ++){
            Console.Clear();
            Console.WriteLine("=========================  EDICION  ===========================\n\n");
            Console.WriteLine("Ingresa el Codigo que deseas Editar \n");
            Int64 opc = Int64.Parse(Console.ReadLine());
            
            if (opc == c.codigo1){
            	Console.WriteLine("\nCodigo: " + c.codigo1 + "\nNombre: " + c.nombre1 + "\nTelefono: " + c.telefono1 + "\nFacebook: " + c.face1);
            	Console.WriteLine("\n===============================================================\n");
            	Console.WriteLine("\nIngresa el nuevo Codigo: \n");
            	c.codigo1 = Int64.Parse(Console.ReadLine());
            	Console.WriteLine("\nIngresa el nuevo Nombre: \n");
            	c.nombre1 = Console.ReadLine();
            	Console.WriteLine("\nIngresa el nuevo Telefono: \n");
            	c.telefono1 = Int64.Parse(Console.ReadLine());
            	Console.WriteLine("\nIngresa el nuevo Facebook: \n");
            	c.face1 = Console.ReadLine();
            	
            }
            if (opc == c.codigo2){
            	Console.WriteLine("\nCodigo: " + c.codigo2 + "\nNombre: " + c.nombre2 + "\nTelefono: " + c.telefono2 + "\nFacebook: " + c.face2);
            	Console.WriteLine("\n===============================================================\n");
            	Console.WriteLine("\nIngresa el nuevo Codigo: \n");
            	c.codigo2 = Int64.Parse(Console.ReadLine());
            	Console.WriteLine("\nIngresa el nuevo Nombre: \n");
            	c.nombre2 = Console.ReadLine();
            	Console.WriteLine("\nIngresa el nuevo Telefono: \n");
            	c.telefono2 = Int64.Parse(Console.ReadLine());
            	Console.WriteLine("\nIngresa el nuevo Facebook: \n");
            	c.face2 = Console.ReadLine();
            }
            if (opc == c.codigo3){
            	Console.WriteLine("\nCodigo: " + c.codigo3 + "\nNombre: " + c.nombre3 + "\nTelefono: " + c.telefono3 + "\nFacebook: " + c.face3);
            	Console.WriteLine("\n===============================================================\n");
            	Console.WriteLine("\nIngresa el nuevo Codigo: \n");
            	c.codigo3 = Int64.Parse(Console.ReadLine());
            	Console.WriteLine("\nIngresa el nuevo Nombre: \n");
            	c.nombre3 = Console.ReadLine();
            	Console.WriteLine("\nIngresa el nuevo Telefono: \n");
            	c.telefono3 = Int64.Parse(Console.ReadLine());
            	Console.WriteLine("\nIngresa el nuevo Facebook: \n");
            	c.face3 = Console.ReadLine();
            }
            if (opc == c.codigo4){
            	Console.WriteLine("\nCodigo: " + c.codigo4 + "\nNombre: " + c.nombre4 + "\nTelefono: " + c.telefono4 + "\nFacebook: " + c.face4);
            	Console.WriteLine("\n===============================================================\n");
            	Console.WriteLine("\nIngresa el nuevo Codigo: \n");
            	c.codigo4 = Int64.Parse(Console.ReadLine());
            	Console.WriteLine("\nIngresa el nuevo Nombre: \n");
            	c.nombre4 = Console.ReadLine();
            	Console.WriteLine("\nIngresa el nuevo Telefono: \n");
            	c.telefono4 = Int64.Parse(Console.ReadLine());
            	Console.WriteLine("\nIngresa el nuevo Facebook: \n");
            	c.face4 = Console.ReadLine();
            }
           }
            Console.Clear();
            Console.WriteLine("=========================  ELIMINACION  ===========================\n\n");
            
            for(int y = 1; y < 3; y ++){
            Console.Clear();
            Console.WriteLine("=========================  ELIMINACION  ===========================\n\n");
             Console.WriteLine("Ingresa el Codigo que deseas ELIMINAR \n");
             Int64 el = Int64.Parse(Console.ReadLine());
             
             if (el == c.codigo1){
            	Console.WriteLine("\nCodigo: " + c.codigo1 + "\nNombre: " + c.nombre1 + "\nTelefono: " + c.telefono1 + "\nFacebook: " + c.face1);
            	Console.WriteLine("\n===============================================================\n");
            	Console.WriteLine("Estas seguro que deseas ELIMINARLA??\n		[1]Si [2]No \n");
            	Int16 br = Int16.Parse(Console.ReadLine());
            	if (br == 1){
            		
            		
            		c.codigo1 = 0;
            		c.nombre1 = "";
            		c.telefono1 = o;
            		c.face1 = "";
            	}
            }
            else if (el == c.codigo2){
            	Console.WriteLine("\nCodigo: " + c.codigo2 + "\nNombre: " + c.nombre2 + "\nTelefono: " + c.telefono2 + "\nFacebook: " + c.face2);
            	Console.WriteLine("\n===============================================================\n");
            	Console.WriteLine("Estas seguro que deseas ELIMINARLA??\n		[1]Si [2]No \n");
            	Int16 br = Int16.Parse(Console.ReadLine());
            if (br == 1){
            		c.codigo2 = 0;
            		c.nombre2 = "";
            		c.telefono2 = 0;
            		c.face2 = "";
            	}
            	
            }
            else if (el == c.codigo3){
            	Console.WriteLine("\nCodigo: " + c.codigo3 + "\nNombre: " + c.nombre3 + "\nTelefono: " + c.telefono3 + "\nFacebook: " + c.face3);
            	Console.WriteLine("\n===============================================================\n");
            	Console.WriteLine("Estas seguro que deseas ELIMINARLA??\n		[1]Si [2]No \n");
            	Int16 br = Int16.Parse(Console.ReadLine());
            	if (br == 1){
            		c.codigo3 = 0;
            		c.nombre3 = "";
            		c.telefono3 = 0;
            		c.face3 = "";
            	}
            
            }
            else if (el == c.codigo4){
            	Console.WriteLine("\nCodigo: " + c.codigo4 + "\nNombre: " + c.nombre4 + "\nTelefono: " + c.telefono4 + "\nFacebook: " + c.face4);
            	Console.WriteLine("\n===============================================================\n");
            	Console.WriteLine("Estas seguro que deseas ELIMINARLA??\n		[1]Si [2]No \n");
            	Int16 br = Int16.Parse(Console.ReadLine());
            	if (br == 1){
            		c.codigo4 = 0;
            		c.nombre4 = "";
            		c.telefono4 = 0;
            		c.face4 = "";
            	}
            	
            	
            }
           
           }
             
            
                Console.Clear();
                
                Console.WriteLine("Los Datos del PRIMER CONTACTO son: \nCodigo: " + c.codigo1 + ("\nNombre: ") + c.nombre1 + ("\nTelefono: ") + c.telefono1 + ("\nFacebook: ") + c.face1);
                Console.WriteLine("===============================================================");
				Console.WriteLine("Los Datos del SEGUNDO CONTACTO son: \nCodigo: " + c.codigo2 + ("\nNombre: ") + c.nombre2 + ("\nTelefono: ") + c.telefono2 + ("\nFacebook: ") + c.face2);
				Console.WriteLine("===============================================================");
				Console.WriteLine("Los Datos del TERCER CONTACTO son: \nCodigo: " + c.codigo3 + ("\nNombre: ") + c.nombre3 + ("\nTelefono: ") + c.telefono3 + ("\nFacebook: ") + c.face3);
				Console.WriteLine("===============================================================");
				Console.WriteLine("Los Datos del CUARTO CONTACTO son: \nCodigo: " + c.codigo4 + ("\nNombre: ") + c.nombre4 + ("\nTelefono: ") + c.telefono4 + ("\nFacebook: ") + c.face4);
				Console.WriteLine("===============================================================");
				
				
			
            
               Console.ReadLine();
            }
        }
    }
