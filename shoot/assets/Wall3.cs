using UnityEngine;
using System.Collections;

public class Wall3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider Catch)
	{
		if (Catch.gameObject.tag == "Monster2") 
		{
			GameContral.Life -=5 ;
		}
		Destroy(Catch.gameObject);	
	}
}
