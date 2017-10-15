using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GeneralManager : MonoBehaviour {
	
	public GameObject votescreen; 
	private bool vote_in_session = false; 
	public GameObject[] votingpanels; 
	public Text yesvotes;
	public Text novotes; 
	//public Text winner; 
	private int yes = 0; 
	private int no = 0;
	private int voted = 0; 
	
	void Start()
	{
		votescreen.SetActive(false);
		foreach(GameObject panel in votingpanels)
			{
				panel.SetActive(false);
			}
	}
	
	public void TriggerVote()
	{
		if(!vote_in_session)
		{
			vote_in_session = true; 
			foreach(GameObject panel in votingpanels)
			{
				panel.SetActive(true);
			}
		}
	}
	
	public void VoteYes()
	{ 
		if(vote_in_session)
		{
			yes++; 
			yesvotes.text = yes.ToString();
			voted++; 
		}
	}
	
	public void VoteNo()
	{ 
		if(vote_in_session)
		{
			no++; 
			novotes.text = no.ToString();
			voted++;
		}
	}
	
	public void EndVote()
	{
		vote_in_session = false; 
		yes = 0;
		no = 0;
		voted = 0;
		novotes.text = no.ToString();
		yesvotes.text = yes.ToString();
	}
	
	public void Quit(){Application.Quit();} //Quits this shits
}
