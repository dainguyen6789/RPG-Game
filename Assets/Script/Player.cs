using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {

	[SerializeField]  float maxHealthPoints=100f;
	[SerializeField] float currentHealthPoints=100f;
	[SerializeField] Weapon sword,rod;
	[SerializeField] AnimatorOverrideController aniOvrdCtrl;
	[SerializeField] GameObject EthanLeftHand;
	static GameObject wp = null;
	//[SerializeField] Button btn;
	Animator anim;
	public float healthAsPercentage
	{
		get
		{
			return currentHealthPoints / (float)maxHealthPoints;
		}
	}

	void OnTriggerEnter(Collider collider)
	{
		currentHealthPoints = currentHealthPoints - 1;
		if (currentHealthPoints < 0)
			currentHealthPoints = 0;
	}
	void Start()
	{
		
		putWeaponInHand ();
		OverrideAnimatorController ();
	}

	void Update(){
		if (Input.GetMouseButtonDown (0))
			anim.SetTrigger ("PlayerAttack");
		//
	}

	private void putWeaponInHand()
	{


	}

	private void OverrideAnimatorController()
	{
		anim = GetComponent<Animator> ();
		anim.runtimeAnimatorController=aniOvrdCtrl;
		aniOvrdCtrl["Default Attack"]=sword.GetAnimClip();;
	}
	public void Load_Sword()
	{
		Debug.Log ("Sword  SwordSwordSwordSwordSwordSwordSword");
		var weaponPrefab = sword.GetWeaponPrefab ();

		if (wp != null) {
			Destroy (wp);
			wp = Instantiate (weaponPrefab);
			wp.transform.SetParent (EthanLeftHand.transform, false);
		}
		else {
			wp = Instantiate (weaponPrefab);
			wp.transform.SetParent (EthanLeftHand.transform, false);
		}

	}

	public void Load_Rod()
	{
		Debug.Log ("Sword  SwordSwordSwordSwordSwordSwordSword");
		var weaponPrefab = rod.GetWeaponPrefab ();

		if (wp != null) {
			Destroy (wp);
			wp = Instantiate (weaponPrefab);
			wp.transform.SetParent (EthanLeftHand.transform, false);
		}
		else {
			wp = Instantiate (weaponPrefab);
			wp.transform.SetParent (EthanLeftHand.transform, false);
		}

	}




}
