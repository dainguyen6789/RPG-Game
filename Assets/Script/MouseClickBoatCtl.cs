using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class MouseClickBoatCtl : MonoBehaviour {
	AICharacterControl aiCharacterControl;
	[SerializeField] GameObject emptyObj;
	// Use this for initialization
	void Start () {
		aiCharacterControl = GetComponent<AICharacterControl> ();
		//emptyObj = Instantiate (Cube);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;

			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) 
			{
				emptyObj.transform.position = hit.point;
				aiCharacterControl.SetTarget(emptyObj.transform);
			}
		}
	}
}
