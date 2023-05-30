public static class Info
{
public static List<Pais> Paises = new List<Pais>();
public static void InicializarLista()
{
Pais argenitna = new Pais ("Argenitna", "/imagenes/Banderas/Argentina.jpg", 46044703, DateTime.Parse("9/7/1816"), " el Mas Monumental");
Pais españa = new Pais ("España", "/imagenes/Banderas/España.jpg", 47615034, DateTime.Parse("17/4/1814"), "el Santiago Bernabeu");
Pais francia = new Pais ("Francia", "/imagenes/Banderas/Francia.jpg", 67871925, DateTime.Parse("14/7/1789"), "la Torre Eiffel");
Pais italia = new Pais ("Italia", "/imagenes/Banderas/Italia.jpg", 58870762, DateTime.Parse("22/8/1849"), "el Coliseo Romano");
Pais brasil = new Pais ("Brasil", "/imagenes/Banderas/Brasil.jpg", 215586573, DateTime.Parse("7/9/1822"), "el Maracaná");
Pais holanda = new Pais ("Holanda", "/imagenes/Banderas/Holanda.jpg", 17591000, DateTime.Parse("26/7/1598"), "el Johan Cruyff Arena");
Pais qatar = new Pais ("Qatar", "/imagenes/Banderas/Qatar.jpg", 2618000, DateTime.Parse("3/9/1971"), "el Lusail Stadium");
Pais inglaterra = new Pais ("Inglaterra", "/imagenes/Banderas/Inglaterra.jpg", 67081000, DateTime.Parse("4/7/1776"), "el Etihad Stadium");
Pais alemania = new Pais ("Alemania", "/imagenes/Banderas/Alemania.jpg", 83794000, DateTime.Parse("3/10/1990"), "el Allianz arena");
Paises.Add(argenitna); 
Paises.Add(españa);
Paises.Add(francia);
Paises.Add(italia);
Paises.Add(brasil);
Paises.Add(holanda);
Paises.Add(qatar);
Paises.Add(inglaterra);
Paises.Add(alemania);
}
public static List<Pais> ListarPaises()
{
    if(Paises.Count<1)
    {
        InicializarLista();
    }
    return Paises;
}

public static Pais DetallePais(string pais)
{
    bool seEncontró = false;
    int i = 0;
    while(seEncontró == false && i<Paises.Count)
    {
        if(Paises[i].Nombre == pais)
        {
            seEncontró = true;
        }
        else
        {
            i++;
        }
        
    }
    return Paises[i];
    }
}

