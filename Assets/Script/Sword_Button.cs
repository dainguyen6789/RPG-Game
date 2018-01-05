using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sword_Button : MonoBehaviour {

	Player player;
	public Button btn;

	// Use this for initialization
	void Start()
	{
		player = FindObjectOfType<Player> ();
		btn = GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}
	void TaskOnClick()
	{
		Debug.Log ("Button Clickkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk");
	}
}
