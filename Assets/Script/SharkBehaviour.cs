using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;


public class SharkBehaviour : MonoBehaviour {

	GameObject player;
	Animator animator;
	AICharacterControl aiCharacterControl;
	[SerializeField] float AttackDistance=3.0f;
	[SerializeField] float ChaseDistance=20.0f;
	[SerializeField] AnimatorOverrideController animationOverrideController;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		aiCharacterControl = GetComponent<AICharacterControl> ();
		animator = GetComponent<Animator>();
		//OverrideAnimatorController ();
		
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance (player.transform.position,transform.position);
		if (distance < ChaseDistance) {
			aiCharacterControl.SetTarget (player.transform);
		} else 
		{
			aiCharacterControl.SetTarget (transform);
		}

		if (distance < AttackDistance) {

			//aiCharacterControl.SetTarget(player.transform);
			animator.SetTrigger("isAttack");
			//SpawnProjectile ();
			//InvokeRepeating ("SpawnProjectile", 0f, 2f);
		} 
		else  
		{
			//isAttacking=false;
			//aiCharacterControl.SetTarget(transform);
			//animator.SetBool("isAttack",false);
			//CancelInvoke ("SpawnProjectile");*/
		}
		
	}

/*	private void OverrideAnimatorController()
	{
		animator = GetComponent<Animator> ();
		animator.runtimeAnimatorController=animatorOverrideController
	}*/
}
