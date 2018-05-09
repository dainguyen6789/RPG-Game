using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class FakeBodyBehaviour : MonoBehaviour {

	[SerializeField] GameObject player;
	AICharacterControl aiCharacterControl;
	// Use this for initialization
	void Start () {

		aiCharacterControl = GetComponent<AICharacterControl> ();
	}
	
	// Update is called once per frame
	void Update () {

		aiCharacterControl.SetTarget (player.transform);
		
	}
}
