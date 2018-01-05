using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenHealthUI : MonoBehaviour {
	Player player;
	Image img;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Player> ();
		img = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		img.fillAmount = player.healthAsPercentage;
		
	}
}
