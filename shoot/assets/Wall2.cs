using UnityEngine;
using System.Collections;

public class Wall2 : MonoBehaviour 
{


	public GameObject ScorePic ;
	
		// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider Catch)
	{
		if (Catch.gameObject.tag == "Monster") 
		{
			GameContral.Life -=1 ;

			if (GameContral.Life <= 0)
			{
				Destroy(gameObject);
				Instantiate (ScorePic) ;
				//AudioSource.PlayClipAtPoint("bazooka");
				Application.LoadLevel("SP4");	
			}
		}

		Destroy(Catch.gameObject);	
}
}
		
