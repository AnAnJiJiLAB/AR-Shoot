using UnityEngine;
using System.Collections;

public class Time2 : MonoBehaviour {
	public Renderer rend;
	float timeRemaining = 5 ;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime ;

		if (timeRemaining < 0) 
		{	
			rend.enabled = true;
		}




	}
}
