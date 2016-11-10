using UnityEngine;
using System.Collections;

public class tiltTable : MonoBehaviour 
{

	public float turnSpeed = 1.0f;

	void Start () 
	{
	
	}

	void FixedUpdate () 
	{
		if (Input.GetAxisRaw ("Horizontal") < 0.0f)
			turn (Vector3.forward, 1.0f);

		if (Input.GetAxisRaw("Horizontal") > 0.0f)
			turn (Vector3.forward, -1.0f);

		if (Input.GetAxisRaw ("Vertical") > 0.0f)
			turn (Vector3.right, 1.0f);

		if (Input.GetAxisRaw("Vertical") < 0.0f)
			downArrow ();

	
	}

	void turn(Vector3 axis, float dir)
	{
		transform.RotateAround (transform.position, axis, turnSpeed * dir);
	}

	void downArrow()
	{
		turn (Vector3.right, -1.0f);
	}


}
