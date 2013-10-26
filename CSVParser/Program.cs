using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser
{
	class Program
	{
		private string @url;
		public void archivo() 
	{
			
		lectura();
		existe();
	}

		private void lectura()
		{
			Console.Write("\n\tIngresa la direccion del archivo .csv a leer... [enter] = salir\n\n\n");
			this.url = Console.ReadLine();
}
		public void existe()
		{
			if (File.Exists(this.url))
		{	
			if (Path.GetExtension(this.url) == ".csv")	
				contenido();

				else
				{
					Console.WriteLine("\n\n\tLA EXTENCION: [" + Path.GetExtension(this.url) + "]... NO ES VALIDA!!\n");
					Console.ReadKey();
					Console.Clear();
					lectura();
				}
		}
				else 
				{
					Console.WriteLine("\n\n\tLA DIRECCION: [" + this.url + "]... NO ES VALIDA!!\n");
					Console.ReadKey();
					Console.Clear();
					lectura();
		}
		
}


	private void contenido() 
	{
		List<string[]> Arreglo = new List<string[]>();
		string fila;
		string[] colum;

				try
				{
					StreamReader leer = new StreamReader(this.url);
						while ((fila = leer.ReadLine()) != null)
						{
							colum = fila.Split(',');
							Arreglo.Add(colum);
						}
				}
					catch (FileNotFoundException e)
					{
						Console.WriteLine(e.Message);
					}

						imprime(Arreglo);
					}

	private void imprime(List<string[]> Arreglo) 
		{
			Console.Clear();
			Console.WriteLine("\nLa Informacion del archivo [" + this.url + "] es: \n\n");
			foreach (string[] array in Arreglo)
 			Console.WriteLine("Id: " + array[0] + 
				              "\nNombre: " + array[1] + 
				              "\nDirección: " + array[2] + 
				              "\nTelefono: " + array[3] + 
				              "\n_______________________________________\n");

		}
	
	static void Main(string[] args)
		{
			Program CSVParser = new Program();
			CSVParser.archivo();
			Console.ReadKey();
		}
	}
}