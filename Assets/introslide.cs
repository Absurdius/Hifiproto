using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class introslide : MonoBehaviour {

	private readonly float CANVAS_CENTERS_DISTANCE = 1420;
	public float speed; 
	public float goal = 0; 
	private int mode = 0; // 0 = INTRO 1=RIGHT 2=LEFT
	private Transform trs;
	// Use this for initialization
	void Start () {
		trs = GetComponent<Transform>(); 
	}
	
	// Update is called once per frame
	void Update () {
		switch (mode){
			case 0:
			if(trs.position.y > goal)
			trs.Translate(0 , - Time.deltaTime * speed, 0);
			break; 
			case 1: 
			if(trs.position.x < goal)
			trs.Translate(Time.deltaTime * speed, 0, 0);
			break; 
			//case 2: 
			//	if(trs.position.x > -goal)
			//	trs.Translate(-Time.deltaTime * speed, 0, 0);
			//break;
		}		
	}
	
	public void moveHoriz(float newgoal){goal = newgoal; mode = 1;} // move right
	public void moveVert(float newgoal){goal = newgoal; mode = 0;} // move up
}
