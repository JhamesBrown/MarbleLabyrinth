using UnityEngine;
using System.Collections;

public class findFollowTransformConstrained : MonoBehaviour {

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
		if (objectToFollow != null) {
			x = (followX) ? objectToFollow.position.x : 0.0f;
			y = (followY) ? objectToFollow.position.y : 0.0f;
			z = (followZ) ? objectToFollow.position.z : 0.0f;
		} else if (objectToFollow == null) {
			if (GameObject.FindGameObjectWithTag("Player") != null )
				objectToFollow = GameObject.FindGameObjectWithTag ("Player").transform;
		}


		transform.localPosition = new Vector3 (x, y, z);
	}
}
