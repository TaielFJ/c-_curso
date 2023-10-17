using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce un numero del 1 al 7:");
        string character = Console.ReadLine();
        int numero;

        mostrarNumeroPorConsola(character);
    }


    static void mostrarNumeroPorConsola(string a)
    {
        int num;
        if (int.TryParse(a, out num))
        {
            if (num >= 1 && num <= 7)
            {
                Console.WriteLine($"Has introducido el número {num}");
            }
            else
            {
                Console.WriteLine("El número no está en el rango del 1 al 7.");
            }
        }
        else
        {
            Console.WriteLine("No has introducido un número válido.");
        }
    }
}