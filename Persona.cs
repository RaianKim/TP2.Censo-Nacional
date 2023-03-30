using System;
class Persona
{
    
    public int DNI{get;private set;}
    public string Apellido{get;set;}
    public string Nombre{get;set;}
    public DateTime FechaNacimiento{get;set;}
    public string MAIL {get;set;}
    private int Edad{get;set;}

public Persona()
{

}
    public Persona( int dni = 0, string ape = "No ingreso ningun valor", string nom = "No ingreso ningun valor" , DateTime fnac = new DateTime(),string Email = "No ingreso ningun valor" )
    {
        DNI = dni;
        Apellido = ape;
        Nombre = nom;
        FechaNacimiento = fnac;
        MAIL = Email;
    }

    // Métodos

    public int MiEdad()
    {
        DateTime FechaNacimientoHoy = new DateTime(DateTime.Today.Year, FechaNacimiento.Month, FechaNacimiento.Day);
        if (FechaNacimientoHoy< DateTime.Today)  Edad = DateTime.Today.Year - FechaNacimiento.Year;
            else   Edad = DateTime.Today.Year - FechaNacimiento.Year -1;
        return Edad; 
    }
}