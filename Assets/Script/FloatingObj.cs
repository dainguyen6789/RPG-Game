﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FloatingObj : MonoBehaviour {
	public float waterLevel = 47.0f;
	public float floatThreshold = 2.0f;
	public float waterDensity = 0.125f;
	public float downForce=1.0f;

	float forceFactor;
	Vector3 floatForce;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		forceFactor = 1.0f - ((transform.position.y - waterLevel) / floatThreshold);

		if (forceFactor > 0.0f) {
			floatForce = -Physics.gravity *  (forceFactor - GetComponent<Rigidbody> ().velocity.y * waterDensity);
			floatForce += new Vector3 (0.0f, -downForce, 0.0f);
			GetComponent<Rigidbody> ().AddForceAtPosition (floatForce, transform.position);
		}
	}
}
