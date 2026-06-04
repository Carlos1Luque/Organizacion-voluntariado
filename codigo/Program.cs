using System;
using System.Collections.Generic;

class Program
{
    static List<Persona> personas = new List<Persona>();

    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== ORGANIZACION SOLIDARIA ===");
            Console.WriteLine("1 - Registrar Voluntario");
            Console.WriteLine("2 - Registrar Coordinador");
            Console.WriteLine("3 - Mostrar Personas");
            Console.WriteLine("0 - Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RegistrarVoluntario();
                    break;

                case 2:
                    RegistrarCoordinador();
                    break;

                case 3:
                    MostrarPersonas();
                    break;
            }

        } while (opcion != 0);
    }

    static void RegistrarVoluntario()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("DNI: ");
        string dni = Console.ReadLine();

        Console.Write("Horas trabajadas: ");
        int horas = int.Parse(Console.ReadLine());

        personas.Add(new Voluntario(nombre, dni, horas));
    }

    static void RegistrarCoordinador()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("DNI: ");
        string dni = Console.ReadLine();

        Console.Write("Área asignada: ");
        string area = Console.ReadLine();

        Console.Write("Cantidad de personas a cargo: ");
        int cantidad = int.Parse(Console.ReadLine());

        personas.Add(new Coordinador(nombre, dni, area, cantidad));
    }

    static void MostrarPersonas()
    {
        foreach (Persona persona in personas)
        {
            persona.MostrarDatos();
        }
    }
}