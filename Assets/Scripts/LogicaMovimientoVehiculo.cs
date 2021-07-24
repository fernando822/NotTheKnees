using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaMovimientoVehiculo : MonoBehaviour
{
    float speed = 1;
    float directionSpeed = 1;


    public void PlayerDemolitionRace_Movement(Vector2 value)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * value.x);

        transform.eulerAngles += new Vector3(0, value.y * Time.deltaTime * directionSpeed, 0);

    }
    public void PlayerDemolitionRace_HandBrake()
    {




    }
    public void PlayerDemolitionRace_Turbo()
    {




    }
    public void Update()
    {







    }

}
