using UnityEngine;
using System.Collections;

public class S4 : MonoBehaviour {

	public AudioSource sound ;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameContral.Score==690){
			
			sound.Play ();
			Destroy(gameObject,6);
			
		}
		
		
	}
}
