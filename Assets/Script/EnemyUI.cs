using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUI : MonoBehaviour {
	Camera cameraToLookAt;

	// Use this for initialization
	void Start () {
		cameraToLookAt = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (cameraToLookAt.transform);
		transform.rotation = Quaternion.LookRotation (cameraToLookAt.transform.forward);
	}
}
