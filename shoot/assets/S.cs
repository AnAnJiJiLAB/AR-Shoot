using UnityEngine;
using System.Collections;

public class S : MonoBehaviour {
	public AudioSource sound ;
	float timeRemaining = 10 ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (timeRemaining < 0) {

			sound.Play ();
			//Destroy(gameObject,6);
			
		}
			
			
		}
	
}
