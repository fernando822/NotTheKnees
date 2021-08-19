using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaMovimientoVehiculo : MonoBehaviour
{
    [SerializeField] DemolitionRacePlayer player;
    [SerializeField] EstadoVehiculo estadoVehiculo;
    [SerializeField] float directionSpeed = 0.1f;
    [SerializeField] float aceleration = 30f;
    [SerializeField] float speedLimit = 70f;
    [SerializeField] float drag = 1f;

    float speed;
    Quaternion anguloDeRotacionEuler;
    Rigidbody rb;
    private RuedaIsGrounded ruedaAdelanteIzq;
    private RuedaIsGrounded ruedaAdelanteDer;
    public animaciones animaciones;


    private void Start()
    {
        player = GetComponent<DemolitionRacePlayer>();
        estadoVehiculo = GetComponent<EstadoVehiculo>();
        ruedaAdelanteIzq = GameObject.Find("Rueda ai").GetComponent<RuedaIsGrounded>();
        ruedaAdelanteDer = GameObject.Find("Rueda ad").GetComponent<RuedaIsGrounded>();
        rb = GetComponent<Rigidbody>();
    }

    public void PlayerDemolitionRaceMovement()
    {
        animaciones.road(speed);
        rb.AddForce(transform.forward * speed, ForceMode.Acceleration);
        rb.MoveRotation(rb.rotation * anguloDeRotacionEuler);
    }

    public void SetSpeedAndRotation(float direccionInputHorizontal, float direccionInputVertical)
    {
        animaciones.direccion(direccionInputHorizontal);

        if (direccionInputVertical != 0 && (ruedaAdelanteDer.GetIsTouchingGroundStatus() || ruedaAdelanteIzq.GetIsTouchingGroundStatus()))
        {
            speed = aceleration * direccionInputVertical;
        }


        Vector3 anguloDeRotacion = new Vector3(0, direccionInputHorizontal * directionSpeed * rb.velocity.magnitude, 0);
        anguloDeRotacionEuler = Quaternion.Euler(anguloDeRotacion * Time.deltaTime);
        
        
    }

    public void PlayerDemolitionRaceHandBrake()
    {

    }

    public void PlayerDemolitionRaceTurbo()
    {
        



    }

    public void FixedUpdate()
    {
        PlayerDemolitionRaceMovement();
    }

    public void SetSpeed(float speed) => this.speed = speed;

    public float GetSpeed() => speed;
}
