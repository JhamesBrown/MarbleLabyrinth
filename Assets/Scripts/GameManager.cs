using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject playerPrefab;

	private GameObject player;
	private Transform spawnPoint;


	void Start () {
		spawnPoint = GameObject.Find ("StartPoint").transform;
	}

	void Update () {

		if (player == null) 
			player = (GameObject)Instantiate (playerPrefab, spawnPoint.position, Quaternion.identity);

	}
}
