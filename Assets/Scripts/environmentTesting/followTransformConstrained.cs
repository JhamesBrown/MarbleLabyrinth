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
		{
			x = (followX) ? objectToFollow.position.x : 0.0f;
			y = (followY) ? objectToFollow.position.y : 0.0f;
			z = (followZ) ? objectToFollow.position.z : 0.0f;
		}


		transform.localPosition = new Vector3 (x, y, z);
	}
}
