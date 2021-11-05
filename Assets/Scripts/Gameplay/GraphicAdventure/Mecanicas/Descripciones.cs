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
        nombreYDescripcion.Add("Mesa de luz", "La unica que me hace compañia por las noches...");
        nombreYDescripcion.Add("Cama", "Ahora no es el momento de dormir, pero bien que me gustaria.");
        nombreYDescripcion.Add("Gasolina", "No estoy muy seguro, pero creo que no debo tomar un trago de esto.");
        nombreYDescripcion.Add("Elevador", "Asi que este va a ser mi fiel corcel, esta lleno de telarañas");
        nombreYDescripcion.Add("EstanteTaller", "Veo que ya no queda practicamente nada en este viejo taller.");
        nombreYDescripcion.Add("CajaHerramientas", "Esto podria serme util mas adelante. \nRecoges Caja de Herramientas");
        nombreYDescripcion.Add("AutoBanana", "Que auto mas extraño, deberia poder ganarle a esto facilmente.");

    }
    
    public Dictionary<string, string> GetNombreYDescripcion()
    {
        return nombreYDescripcion;
    }
}
