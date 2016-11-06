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
		if (Input.GetKey (KeyCode.LeftArrow))
			turn (Vector3.forward, 1.0f);

		if (Input.GetKey (KeyCode.RightArrow))
			turn (Vector3.forward, -1.0f);

		if (Input.GetKey (KeyCode.UpArrow))
			turn (Vector3.right, 1.0f);

		if (Input.GetKey (KeyCode.DownArrow))
			downArrow ();

	
	}

	void turn(Vector3 axis, float dir)
	{
		transform.RotateAround (transform.position, axis, turnSpeed * dir);
	}

	void downArrow()
	{
		// Debug.Log ("downarrow pressed");
		turn (Vector3.right, -1.0f);
	}
}
