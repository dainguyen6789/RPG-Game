using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour {
	[SerializeField] float maxHealth=100.0f;
	[SerializeField] float currentHealth=100.0f;
	[SerializeField] float healthPercentage;

	RawImage rawImage;
	// Use this for initialization
	void Start () {
		rawImage = GetComponent<RawImage> ();
	}
	
	// Update is called once per frame
	void Update () {
		healthPercentage = currentHealth / maxHealth;

		//if (healthPercentage <= 1 && healthPercentage >= 0.5) {
			//Rect.x=0; Rect.W=3/2-p
		rawImage.uvRect=new Rect((float)((1-healthPercentage)/2),0,0.5f,1);
		//} else if (healthPercentage < 0.5) {
			//Rect.x=0.5, Rect.W=1/2+p
			//rawImage.uvRect=new Rect(0.5f,0,1/2+healthPercentage,1);
		//}
			
		//rawImage.uvRect = new Rect ();	
	}
}
