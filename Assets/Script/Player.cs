using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField]  float maxHealthPoints=100f;
	[SerializeField] float currentHealthPoints=100f;
	[SerializeField] Weapon weapon;
	[SerializeField] AnimatorOverrideController aniOvrdCtrl;
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
	}

	private void putWeaponInHand()
	{
		var weaponPrefab = weapon.GetWeaponPrefab ();
		var wp = Instantiate (weaponPrefab);
	}

	private void OverrideAnimatorController()
	{
		anim = GetComponent<Animator> ();
		anim.runtimeAnimatorController=aniOvrdCtrl;
		aniOvrdCtrl["Default Attack"]=weapon.GetAnimClip();;
	}




}
