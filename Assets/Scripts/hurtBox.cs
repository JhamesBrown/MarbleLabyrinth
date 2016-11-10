using UnityEngine;
using System.Collections;

public class hurtBox : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{

		if (col.gameObject.tag == "Player")
			Destroy (col.gameObject);	
	}
}
