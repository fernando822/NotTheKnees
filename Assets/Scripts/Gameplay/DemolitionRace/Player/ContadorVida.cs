using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ContadorVida : MonoBehaviour
{
    public int VidaACambiar;
    public string objetoColision;
  
    CausarDaño causarDañoP;
    CausarDaño causarDañoE;

    void Start()
    {
        causarDañoP = GameObject.Find("Player").GetComponent<CausarDaño>();
        causarDañoE = GameObject.Find("Enemy").GetComponent<CausarDaño>();

    }

    public void CambiarVida(int VidaACambiar, string objetoColision)
    {
        if (objetoColision == "Player")
            causarDañoP.ControlVida(VidaACambiar);

        if (objetoColision =="Enemy")
            causarDañoE.ControlVida(VidaACambiar);

       
       
    }

  

    private void Update()
    {
       
    }



}
