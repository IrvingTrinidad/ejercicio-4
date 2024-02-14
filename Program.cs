using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresar un número del 1 al 7:");
        int numero = Convert.ToInt32(Console.ReadLine());

        string nombreDia = ObtenerNombreDia(numero);

        Console.WriteLine($"El día correspondiente al número {numero} es {nombreDia}.");
    }

    static string ObtenerNombreDia(int numero)
    {
        switch (numero)
        {
            case 1:
                return "Lunes";
            case 2:
                return "Martes";
            case 3:
                return "Miércoles";
            case 4:
                return "Jueves";
            case 5:
                return "Viernes";
            case 6:
                return "Sábado";
            case 7:
                return "Domingo";
            default:
                return "Número inválido, debe estar entre 1 y 7";
        }
    }
}
