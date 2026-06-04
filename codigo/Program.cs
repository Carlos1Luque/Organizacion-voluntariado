using System;
using System.Collections.Generic;

class Program
{
    static List<Voluntarios> voluntarios = new List<Voluntarios>();
    static List<Coordinadores> coordinadores = new List<Coordinadores>();

    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\nSeleccione una opción:");
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
        Console.WriteLine("Nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("DNI: ");
        string dni = Console.ReadLine();

        Console.WriteLine("Horas trabajadas: ");
        int horasTrabajadas = int.Parse(Console.ReadLine());
        Console.WriteLine("Voluntario registrado exitosamente.");

        voluntarios.Add(new Voluntarios(nombre, dni, horasTrabajadas));
    }

    static void RegistrarCoordinador()
    {
        Console.WriteLine("Nombre: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("DNI: ");
        string dni = Console.ReadLine();

        Console.WriteLine("Área asignada: ");
        string areaAsignada = Console.ReadLine();

        Console.WriteLine("Cantidad de personas a cargo: ");
        int personasACargo = int.Parse(Console.ReadLine());
        Console.WriteLine("Coordinador registrado exitosamente.");

        coordinadores.Add(new Coordinadores(nombre, dni, areaAsignada, personasACargo));
    }

    static void MostrarPersonas()
    {
        Console.WriteLine("Desea ver a los voluntarios o a los coordinadores? (V/C)");
        string opcion = Console.ReadLine();

        if (opcion.ToUpper() == "V")
        {
            Console.WriteLine("\nLos voluntarios registrados son:");
            foreach (Voluntarios voluntario in voluntarios)
            {
                voluntario.MostrarInformacion();
            }
        }
        else if (opcion.ToUpper() == "C")
        {
            Console.WriteLine("\nLos coordinadores registrados son:");
            foreach (Coordinadores coordinador in coordinadores)
            {
                coordinador.MostrarInformacion();
            }
        }
    }
}