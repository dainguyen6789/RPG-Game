using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour {
	Player player;
	Vector3 dist;
	float height_above_rivermesh;
	float temp;
	[SerializeField] GameObject rivermesh;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Player> ();
		dist = (transform.position- player.transform.position);
		height_above_rivermesh=(transform.position- rivermesh.transform.position).z;
	}
	
	// Update is called once per frame
	void Update () {
		 transform.position = dist + player.transform.position;
		//temp = rivermesh.transform.position.z + height_above_rivermesh;
		//transform.position =transform.position+Vector3.forward*temp;

	}
}
