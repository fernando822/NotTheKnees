using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaMovimientoVehiculo : MonoBehaviour
{
	public float aceleration = 1;
	public float speedLimit = 10;
	public float drag = 0.1f;
	public float speed;

	public float directionSpeed = 1;
	public float directionSpeedLimit = 1;
	public float angulo;


	public void PlayerDemolitionRace_Movement()
	{
		speed += Time.deltaTime * aceleration * 1;

		speed = speed * (1 - drag * Time.deltaTime);

		speed = Mathf.Clamp(speed, -speedLimit * 0.2f, speedLimit);

		transform.Translate(Vector3.forward * speed * Time.deltaTime);


		angulo = 1 * directionSpeed * speed * Time.deltaTime;

		angulo = Mathf.Clamp(angulo, -directionSpeedLimit, directionSpeedLimit);

		transform.Rotate(Vector3.up, angulo);
	}


	public void PlayerDemolitionRace_HandBrake()
    {




    }
    public void PlayerDemolitionRace_Turbo()
    {




    }
    public void Update()
    {
        
        PlayerDemolitionRace_Movement();






    }

}
