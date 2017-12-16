using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour {

	RawImage healthBarRawImage;
	Player player;

	void Start()
	{
		player = FindObjectOfType<Player> ();
		healthBarRawImage = GetComponent<RawImage> ();
	}

	void Update()
	{
		float xValue = -(player.healthAsPercentage / 2f) + 0.5f;
		//healthBarRawImage.uvRect = new Rect (xValue, 0f, 0f, 1f);

	}
}
