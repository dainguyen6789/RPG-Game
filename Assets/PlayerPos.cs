using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour {

	[SerializeField] GameObject boat;
	Vector3 init_dis;
	// Use this for initialization
	void Start () {
		init_dis = boat.transform.position - transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = boat.transform.position - init_dis;
		transform.rotation = boat.transform.rotation;
	}
}
