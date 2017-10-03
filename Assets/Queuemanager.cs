using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queuemanager : MonoBehaviour {

	// classic FIFO queue
	// holds a queue 
	private GameObject[] queue; 
	
	public void qelement(string name)
	{
		//create new text 
		private GameObject nameObject;
		nameObject = new Text(name); 
		
		//add to queue
		queue.add(nameObject);
	}
	
	//called when someone wants to exit
	public void moveup () 
	{
		//delete first element in queue
		
		//animate upward movement of the rest
		//DO NOT SWAP WITHIN THE ARRAY	
		
	}
	
	private GameObject findFirst()
	{
		int indx = 0; 
		while (queue[indx] == null){indx++;}
		return queue[indx]; 
	}
	
	//called once per frame use this to animate
	void Update()
	{
		//trs.Translate(0 ,0, 0); Sample translation
	}
}
