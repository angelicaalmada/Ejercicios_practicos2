using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_practicos2
{
    public class Ejercicios
    {
        public void ejercicio1()
        {
            Console.WriteLine("Ingrese el numero de elementos ");
            int elementos = Convert.ToInt32(Console.ReadLine());
            int [] arreglo1 = new int[elementos];
            int [] arreglo2 = new int[elementos];
            int [] arreglo3 = new int[elementos];

            for (int i = 0; i < arreglo1.Length; i++)
            {
                Console.WriteLine("ingrese el valor del arreglo 1 ");
                arreglo1[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese el valor del arreglo 2 ");
                arreglo2[i] = Convert.ToInt32(Console.ReadLine());
                arreglo3[i]= arreglo1[i] + arreglo2[i];
            }

            for (int i = 0; i < arreglo1.Length; i++)
            {
                Console.WriteLine($"{arreglo1[i]} + {arreglo2[i]} = {arreglo3[i]}");
            }
        }




        public void ejercicio2()
        {
            int[] arreglo = new int[] { 10, 20, 30, 20, 50, 10};
            Console.WriteLine("Ingrese el numero a buscar");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arreglo2 = new int[5];
            int indice = 0;

            for(int i=0; i< arreglo.Length; i++)
            {
                if (arreglo[i] == num)
                {
                    arreglo2[indice] = i;
                    indice++;
                }

            }
            for(int i=0; i< indice; i++)
            {
                Console.WriteLine("El numero esta en la posicion: "+arreglo2[i]);
            }
        }

        public void ejercicio3()
        {
            int[] algebra = new int[5];
            int[] analisis = new int[5];
            int[] alumRepetidos = new int[5];
            int posiciones = 0;

            Console.WriteLine("Materia de algebra");
            for(int i=0; i<algebra.Length; i++)
            {
                Console.WriteLine("Ingrese el Id del alumno");
                algebra[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Materia de analisis");
            for(int i=0; i<analisis.Length; i++)
            {
                Console.WriteLine("Ingrese el id de  alumno");
                analisis[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < algebra.Length; i++)
            {
                for(int x = 0; x < analisis.Length; x++)
                {
                    if (algebra[i]== analisis[x])
                    {
                        alumRepetidos[posiciones]= algebra[i];
                        posiciones++;
                    }
                }
            }

            for(int i = 0; i < posiciones; i++)
            {
                Console.WriteLine("Los alimnos repetidos son: " +alumRepetidos[i]);
            }
        }



        public void ejercicio4()
        {
            Console.WriteLine("ingrese numero de elementos");
            int elementos = Convert.ToInt32(Console.ReadLine());
            int[] arreglo = new int[elementos];
            for(int i=0; i< arreglo.Length; i++)
            {
                Console.WriteLine("Ingrese el valor del elemento sin repetir");
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0;i < arreglo.Length; i++)
            {
                Console.WriteLine("El contenido de los valores son: " +arreglo[i]);
            }
        }



        public void ejercicio5()
        {
            Console.WriteLine("Ingrese numero de elementos");
            int elementos = Convert.ToInt32(Console.ReadLine());
            int[] arreglo = new int[elementos];
            double promAprobadas = 0;
            double probDesaprobadas = 0;
            int cantAprobaas = 0;
            int cantDesaprobadas = 0;
            int sumaAprobadas = 0;
            int sumaDesaprobadas = 0;

            for(int i=0; i< arreglo.Length; i++)
            {
                Console.WriteLine("Ingrese la nota del 0 al 20");
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] >= 6)
                {
                    cantAprobaas++;
                    sumaAprobadas = sumaAprobadas + arreglo[i];
                }
                else
                {
                    cantDesaprobadas++;
                    sumaDesaprobadas = sumaDesaprobadas + arreglo[i];
                }
            }

            promAprobadas = sumaAprobadas / cantAprobaas;
            probDesaprobadas = sumaDesaprobadas / cantDesaprobadas;
            Console.WriteLine($"El promedio de Aprobados es {promAprobadas} y el de desaprobados es {probDesaprobadas}");
        }
     
    }
}
