using UnityEngine;
using System.Collections;

public class Shock5 : MonoBehaviour {
	public Renderer rend;
	public AudioSource audio ;
	float timeRemaining = 0 ;
	void Start () 
	{
		rend = GetComponent<Renderer>();
		rend.enabled = false;
		audio = GetComponent<AudioSource> ();
		audio.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		timeRemaining += Time.deltaTime ;
		if (timeRemaining >180) 
		{
			rend.enabled = true;
			audio.enabled = true;
			Destroy(gameObject,6);
		}
		
	}
}
