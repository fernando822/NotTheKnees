using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class EstadoVehiculo : MonoBehaviour
{
    ControladorVida contadorVida;
    [SerializeField] TextMeshProUGUI text;

    Rigidbody rb;

    public int vida;
    public int attack = 2;
    float tiempoDaño;
    [SerializeField] float esperaDaño = 1;
    [HideInInspector]public Vector3 speedV3;

    void Awake()
    {
        contadorVida = GameObject.Find("LifeController").GetComponent<ControladorVida>();
        if(this.gameObject.tag == "Player")
            text = GameObject.Find("NumeroDaño").GetComponent<TextMeshProUGUI>();
        else
            this.text = GameObject.Find("NumeroDañoEnemigo").GetComponent<TextMeshProUGUI>();
        rb = GetComponent<Rigidbody>(); 
    }
    private void Start()
    {
        this.vida = 100;
        Estados.ModificarEstado("gameOver", false);
    }
    private void Update()
    {
       cartelDaño();
    }

    void OnCollisionEnter(Collision other)
    {
        this.speedV3 = this.rb.velocity;

        if (other.gameObject.tag == "Player")
            contadorVida.CambiarVida(speedV3, other.rigidbody.velocity, other.collider.tag, this.attack);


        if (other.gameObject.tag == "Enemy")
            contadorVida.CambiarVida(speedV3, other.rigidbody.velocity, other.collider.name, this.attack);

        Debug.Log("Vida de " +this.name +": "+ this.vida);
    }

    public void RecibirDaño(int daño)
    {
        this.vida -= daño;
        this.text.text = "" + -daño;
        this.tiempoDaño = this.esperaDaño;
    }

    void cartelDaño()
    {
        if (this.tiempoDaño > 0) 
        {
            this.tiempoDaño -= Time.deltaTime;

            if (this.tiempoDaño <= 0)
                this.text.text = "";
        }
    }
}
