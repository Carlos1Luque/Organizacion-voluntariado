class Voluntarios : Personas
{
    private int horasTrabajadas;
    public int HorasTrabajadas{ get { return this.horasTrabajadas; } set { this.horasTrabajadas = value; } }
        public Voluntarios(string nombre, string dni, int horasTrabajadas): base(nombre, dni)
    {
        HorasTrabajadas = horasTrabajadas;
    }
        
        public override void MostrarInformacion()
    {
        Console.WriteLine($" TIPO: Voluntario");
        Console.WriteLine($" Nombre: {Nombre}");
        Console.WriteLine($" DNI: {Dni}");
        Console.WriteLine($" Horas Registradas: {HorasTrabajadas} hs");
    }
    }
