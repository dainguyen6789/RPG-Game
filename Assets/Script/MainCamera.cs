using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {

	Player player;
	Vector3 distance;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Player> ();
		distance = transform.position - player.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + distance;
		//transform.rotation = player.transform.rotation;
	}
}
