using System;


namespace projecto06
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota01, nota02, nota03;
            string nombre;
            System.Console.WriteLine("Ingrese el nombre del alumno :");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la Nota 01 :");
            nota01 = int.Parse(Console.ReadLine());
            if (nota01>=0 && nota01<=20)
            {
                Console.WriteLine("la nota es correcta");
            }
            else
            {
                nota01 = 0;
                Console.WriteLine("la nota es incorrecta");
            }
            Console.WriteLine("Ingrese la Nota 02 :");
            nota02 = Convert.ToInt32(Console.ReadLine());
            if (nota02 >= 0 && nota02 <= 20)
            {

            }
            else
            {
                nota02 = 0;
                Console.WriteLine("la nota es incorrecta");
            }
            Console.WriteLine("Ingrese la Nota 03 :");
            nota03 = int.Parse(Console.ReadLine());
            if (nota03 >= 0 && nota03 <= 20)
            {

            }
            else
            {
                nota03 = 0;
                Console.WriteLine("la nota es incorrecta");
            }
            double promedio = 0;
            promedio = (nota01 + nota02 + nota03) / 3.0;

            Console.WriteLine("El promedio es : {0}  y su nombres es :{1} ", promedio,nombre);
            Console.ReadKey();
        }
    }
}
