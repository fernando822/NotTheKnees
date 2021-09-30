using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descripciones : MonoBehaviour
{
    private Dictionary<string, string> nombreYDescripcion;
    private void Awake()
    {
        nombreYDescripcion = new Dictionary<string, string>();
        nombreYDescripcion.Add("Cuadro", "Es un poster de mi videojuego favorito, \"La mansion del Mario verde\".");
        nombreYDescripcion.Add("Estante", "Un estante lleno de cosas basura.");
        nombreYDescripcion.Add("Armario", "Aca guardo mi ropa, aunque todas son exactamente iguales.");
        nombreYDescripcion.Add("Basura", "No quiero ni mirar lo que hay ahí adentro.");
        nombreYDescripcion.Add("Cama", "Ahora no es el momento de dormir.");
        nombreYDescripcion.Add("Gasolina", ".");
        nombreYDescripcion.Add("Elevador", ".");
        nombreYDescripcion.Add("EstanteTaller", "Veo que ya no queda practicamente nada en este viejo taller.");
        nombreYDescripcion.Add("CajaHerramientas", ".");

    }
    
    public Dictionary<string, string> GetNombreYDescripcion()
    {
        return nombreYDescripcion;
    }
}
