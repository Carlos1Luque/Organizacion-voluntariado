using System;
class Coordinadores : Personas
{
    private string areaAsignada;
    private int personasACargo;
    public string AreaAsignada { get { return this.areaAsignada; } set { this.areaAsignada = value; } }
    public int PersonasACargo { get { return this.personasACargo; } set { this.personasACargo = value; } }
    public Coordinadores(string nombre, string dni, string areaAsignada, int personasACargo) : base(nombre, dni)
    {

        AreaAsignada = areaAsignada;
        PersonasACargo = personasACargo;
    }
    public override void MostrarInformacion()
    {
        Console.WriteLine($" TIPO: Coordinador");
        Console.WriteLine($" Nombre: {Nombre}");
        Console.WriteLine($" DNI: {Dni}");
        Console.WriteLine($" Área Asignada: {AreaAsignada}");
        Console.WriteLine($" Personal a Cargo: {PersonasACargo} personas");
    }
}