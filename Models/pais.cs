public class Pais
{
public string Nombre {get; private set;}
public string ImgBandera {get; private set;}
public int Poblacion {get; private set;}
public DateTime FechaIndepencia {get; private set;}
public string AtractivosTuristicos{get; private set;}

public Pais (string nombre, string imgbandera, int poblacion, DateTime fechaindependencia, string atractivosturisticos)
{
Nombre = nombre;
ImgBandera = imgbandera;
Poblacion = poblacion;
FechaIndepencia = fechaindependencia;
AtractivosTuristicos = atractivosturisticos;
}
}