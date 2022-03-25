using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, categoria, ejemplares;
            int cInformatica = 0;
            float aInformatica = 0, aCiencia=0, porcentajeCiencia=0, aTotalEjemplares=0;

            Console.WriteLine("Bienvenidos a la Biblioteca");
            Console.WriteLine();
            Console.WriteLine("Ingrese el código del Libro: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            while(codigo!=0)
            {
                Console.WriteLine("Ingrese la Categoría: | 1-Informática | 2-Ciencia | 3-Ficción | 4-Otro |");
                categoria = Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine("ingrese la cantidad de Ejemplares: ");
                ejemplares = Convert.ToInt32(Console.ReadLine());
                aTotalEjemplares += ejemplares;

                if (categoria == 1)
                {
                    cInformatica++;
                    aInformatica += ejemplares;
                }
                if(categoria==2)
                {
                    aCiencia += ejemplares;
                }

                porcentajeCiencia = (aCiencia / aTotalEjemplares) * 100;

                Console.WriteLine("Ingrese el código del Libro: ");
                codigo = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine();
            Console.WriteLine("Cantidad de libros de la Categoría Informática: " + cInformatica);
            Console.WriteLine("Cantidad de ejemplares de la Categoría Informática: " + aInformatica);
            Console.WriteLine("Porcentaje de Libros de Categoría Ciencia: " + porcentajeCiencia + " %");
            Console.WriteLine("Total de ejemplares en la Biblioteca: " + aTotalEjemplares);
            Console.Read();
        }
    }
}
