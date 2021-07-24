using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaMovimientoVehiculo : MonoBehaviour
{
    
    float directionSpeed = 1;
    float aceleration =1;
    float speedLimit = 10;

    public void PlayerDemolitionRace_Movement(Vector2 value)
    {
        float speed =+ Time.deltaTime * aceleration * value.x;
        speed = Mathf.Clamp(speed,-speedLimit * 0.1f, speedLimit);

        transform.Translate(Vector3.forward * speed);


        if(speed != 0)
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
