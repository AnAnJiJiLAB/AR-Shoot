using UnityEngine;
using System.Collections;

public class Playerrrr : MonoBehaviour {

	//public GameObject ScorePic ;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider Catch)
	{
		if (Catch.gameObject.tag == "T") 
		{

			GameContral.Life -=2 ;
		}
		
		Destroy(Catch.gameObject);	
	}
}
