using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescripcionesObjetosClave
{
    private string DescripcionLlaveDeGarage = "La llave del taller que me dio mi tio.";
    private string DescripcionPaseDeCarrera = "Un certificado que me permite ingresar al torneo.";
    private string DescripcionCajaDeHerramienta = "Podria usar estas herramientas para algo...";


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
