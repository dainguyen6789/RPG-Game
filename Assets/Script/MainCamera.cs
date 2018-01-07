using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {

	Player player;
	[SerializeField] GameObject boat;
	Vector3 distance, distancetoBoat;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Player> ();
		//boat = FindObjectOfType<Boat> ();
		distance = transform.position - player.transform.position;
		distancetoBoat = transform.position - boat.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = player.transform.position + distance;
		//transform.rotation = player.transform.rotation;
		transform.position=boat.transform.position+distancetoBoat;
	}
}
