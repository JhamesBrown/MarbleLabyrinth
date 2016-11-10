using UnityEngine;
using System.Collections;

public class EndGoal : MonoBehaviour {



	void OnCollisionEnter(Collision col)
	{

		if (col.gameObject.tag == "Player")
			gameComplete (col.gameObject);
		
	}


	void gameComplete(GameObject player)
	{
		Debug.Log ("GAME COMPLETE");
		Destroy (player);	
	}


}
