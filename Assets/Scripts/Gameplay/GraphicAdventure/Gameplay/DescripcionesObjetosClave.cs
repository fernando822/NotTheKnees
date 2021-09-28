using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescripcionesObjetosClave : MonoBehaviour
{
    private string DescripcionLlaveDeGarage = "Con esta llave puedo abrir el garage donde se encuentra mi auto para participar en la carrera de demolicion.";
    private string DescripcionPaseDeCarrera = "Un certificado que me permite ingresar al torneo.";
    private string DescripcionCajaDeHerramienta = "Con esta caja puedo arreglar o desarreglar algun que otro componente.";


    public string MostrarDescripcionLlaveDeGarage()
    {
        return DescripcionLlaveDeGarage;
    }
    public string MostrarDescripcionPaseDeCarrera()
    {
        return DescripcionPaseDeCarrera;
    }
    public string MostrarDescripcionCajaDeHerramienta()
    {
        return DescripcionCajaDeHerramienta;
    }
}
