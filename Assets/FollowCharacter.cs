using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;




public class FollowCharacter : MonoBehaviour {
    public ThirdPersonCharacter thirdPerson;
	public GameObject emptyObj;
	Vector3 offset;
	float dist;
    // Use this for initialization
    void Start () {
		offset=transform.position - thirdPerson.transform.position;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		dist = Vector3.Distance (emptyObj.transform.position, thirdPerson.transform.position);
			if (dist>0.3)
			{
        		transform.position = thirdPerson.transform.position+offset;
			}
        //transform.rotation = thirdPerson.transform.rotation;

    }
}
