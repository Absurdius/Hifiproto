using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attendeemanager : MonoBehaviour {

	RawImage background; 
	// 0 = neutral
	// 1 = waiting
	// 2 = speaking
	/* TRANSITIONS
		0 => 1
		1 => 2
		1 => 0 // if leader decides to disallow speaker
		2 => 0
	*/
	private int state = 0; 
	private float colorvalue = 0; 
	
	// Use this for initialization
	void Start () {
		background = GetComponent<RawImage>();
		background.color = new Color(1, 1, 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
		// background changes based on state.
		switch (state){
			case 1:	
				if(colorvalue < 1.0f){
				background.color = Color.Lerp(background.color, Color.yellow, colorvalue += Time.deltaTime);
				}
			break;
			case 2: 
				if(colorvalue < 1.0f){
				background.color = Color.Lerp(background.color, Color.green, colorvalue += Time.deltaTime);
				}
			break;
			default : 
				if(colorvalue < 1.0f){
				background.color = Color.Lerp(background.color, Color.white, colorvalue += Time.deltaTime);
				}
			break;
		}
	}
	
	public void SetStateWait()
	{
		colorvalue = 0;
		state = 1; 
	}
	
	public void SetStateSpeak()
	{
		colorvalue = 0;
		state = 2; 
	}
}
