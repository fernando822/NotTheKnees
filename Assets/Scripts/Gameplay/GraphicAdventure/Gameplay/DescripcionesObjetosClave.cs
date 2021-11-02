using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescripcionesObjetosClave
{
    private string DescripcionLlaveDeGarage = "La llave del garaje que me dio mi tío. The garage key that my uncle gave me";
    private string DescripcionPaseDeCarrera = "Un certificado que me permite participar en el torneo. A certificate that allows me to participate in the tournament.";
    private string DescripcionCajaDeHerramienta = "Podría usar estas herramientas para algo... I could use these tools for something ...";


    public string GetDescripcionLlaveDeGarage()
    {
        return DescripcionLlaveDeGarage;
    }
    public string GetDescripcionPaseDeCarrera()
    {
        return DescripcionPaseDeCarrera;
    }
    public string GetDescripcionCajaDeHerramienta()
    {
        return DescripcionCajaDeHerramienta;
    }
}
