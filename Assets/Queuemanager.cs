using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Queuemanager : MonoBehaviour {

	private Transform trs;
	private Queue<GameObject> generalqueue;
	public GameObject bubble; 
	
	void Start(){
	trs = GetComponent<Transform>();
	generalqueue = new Queue<GameObject>(); 
	}
	
	private float goal;
	
	//called when user wants ehe word
	public void qelement(String name)
	{		
		GameObject obj = Instantiate(bubble);
		obj.transform.SetParent(trs);
		generalqueue.Enqueue(obj); 
		//writeResults();
	}
	
	//called when someone wants to exit
	public void moveup () 
	{
		if(generalqueue.Count != 0)
		{
		GameObject first = generalqueue.Dequeue();
		Destroy(first);
		writeResults();
		}
	}
	
	private void writeResults()
	{
		int indx = 0;
		foreach (GameObject name in generalqueue)
		{
			goal = 100 - 50*indx; 
			Transform trans = name.GetComponent<Transform>();
			trans.Translate(0, goal, 0);
			indx++;
		}
	}
	
	
	
	/*
	called once per frame use this to animate
	void Update()
	{
		if(animate)
		{ 
			foreach (GameObject name in generalqueue)
			{
				goal = -100 - 20*indx; 
				Transform trans = name.GetComponent<Transform>();
				if(trs.position.y < goal){}
				
			}
		}
	}
	*/
	
}
