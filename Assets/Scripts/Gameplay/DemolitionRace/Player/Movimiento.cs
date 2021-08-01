using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movimiento : MonoBehaviour
{
	Rigidbody m_Rigidbody;


	public float aceleration = 100;
	public float speedLimit = 100;
	public float drag = 0.1f;
	public float speed;

	public float directionSpeed = 1;
	public float directionSpeedLimit = 1;
	public float angulo;
	public float y,force,g;
	

	private void Start()
    {
		m_Rigidbody = GetComponent<Rigidbody>();
	}

    public void PlayerDemolitionRace_Movement()
	{
		speed = m_Rigidbody.velocity.magnitude;

		force = aceleration * y * (1- ((float)speed / speedLimit));

		m_Rigidbody.AddForce(transform.forward * force);


		g = 1 - ((float)speed / speedLimit);





	}

	
	void Update()
    {
		y= Input.GetAxis("Vertical");
		PlayerDemolitionRace_Movement();
	}
}
