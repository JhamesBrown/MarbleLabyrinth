using UnityEngine;
using System.Collections;

public class followTransformConstrained : MonoBehaviour {

	public Transform objectToFollow;
	public bool followX;
	public bool followY;
	public bool followZ;

	private float x;
	private float y;
	private float z;

	void Start () 
	{
	
	}

	void FixedUpdate () 
	{
		if (objectToFollow != null)
			

		x = (followX)



		transform.localPosition = new Vector3 (x, y, z);
	}

	void followWithConstraints()
	{

	}
}
