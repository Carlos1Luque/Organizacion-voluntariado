using System;
abstract class Personas
{
    private string nombre;
    private string dni;
    int horas_trabajadas;
    public string Nombre {get {return this.nombre;} set {this.nombre = value;}}
    public string Dni {get {return this.dni;} set {this.dni = value;}}
    public int HorasTrabajadas {get {return this.horas_trabajadas;} set {this.horas_trabajadas = value;}}

    public Personas(string nombre, string dni, int horas_trabajadas)
    {
        Nombre = nombre;
        Dni = dni;
        HorasTrabajadas = horas_trabajadas;
    }

    public abstract void MostrarInformacion();  
   
} 