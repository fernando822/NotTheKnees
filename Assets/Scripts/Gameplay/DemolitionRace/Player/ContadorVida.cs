using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorVida : MonoBehaviour
{
    public int vida;
    public int VidaACambiar;
    public Image BarraDeVida;

    void Start()
    {
     vida = 100;
    }

    public void CambiarVida (int VidaACambiar)
    {
        vida += VidaACambiar;

        if (vida <= 0)
            Destroy(gameObject);

        vida = Mathf.Clamp(vida, 0, 100);

        BarraDeVida.fillAmount = vida * 0.01f ;
    }
    private void Update()
    {
        CambiarVida(0);
    }



}
