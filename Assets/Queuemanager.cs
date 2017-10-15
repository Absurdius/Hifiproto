using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Queuemanager : MonoBehaviour {

	private Transform trs;
	private Queue<GameObject> generalqueue;
	public GameObject bubble; 
	public String[] prequeue;
	//public MonoBehaviour manager; // could be used to reach user
	
	void Start(){
	trs = GetComponent<Transform>();
	generalqueue = new Queue<GameObject>(); 
	
		if(prequeue.Length > 0)
		{
			foreach (String s in prequeue)
			{
				qelement(s);
			}
		}
	}
	
	private float goal;
	
	//called when user wants ehe word
	public void qelement(String name)
	{		
		GameObject obj = Instantiate(bubble);
		Text thename = obj.GetComponentInChildren<Text>();
		thename.text = name;
		obj.transform.SetParent(trs);
		if(trs == null){Debug.Log("no transform");}
		generalqueue.Enqueue(obj); 
		Transform trans = obj.GetComponent<Transform>();
		trans.Translate(trs.position.x, 250 -50 * generalqueue.Count , 0);
		if(generalqueue.Count == 1){ highlight(generalqueue.Peek()); }
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
		//might look weird
		//but queue can be empty after destroy operation
		if(generalqueue.Count != 0)
		{
			highlight(generalqueue.Peek());
		}
		
	}
	
	
	
	private void writeResults()
	{
		foreach (GameObject name in generalqueue)
		{
			Transform trans = name.GetComponent<Transform>();
			//Vector3 pos = trans.position + new Vector3(0.0f, 50.0f, 0.0f); 
			trans.Translate( new Vector3(0.0f, 50.0f, 0.0f));
		}
	}
	
	
	private void highlight(GameObject obj)
	{
		obj.GetComponent<Transform>().localScale = new Vector3 (1.2f, 1.2f, 1.0f);
		obj.GetComponent<Transform>().Translate(new Vector3 (0.0f, 20.0f, 0.0f));
		
		/*
		GameObject speaker = GameObject.Find(obj.GetComponentInChildren<Text>().text);
		if(speaker == null)
		{
			Debug.Log("speaker not found");
			Debug.Log(obj.GetComponentInChildren<Text>().text);
		}
		else {speaker.GetComponent<Attendeemanager>().SetStateSpeak(); }
		*/
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
