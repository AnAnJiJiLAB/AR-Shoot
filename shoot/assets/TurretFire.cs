using UnityEngine;
using System.Collections;

public class TurretFire : MonoBehaviour {
	public GameObject Monster ;
	//public GameObject Monster2 ;
	public float MonsterFire;
	public float MonsterFireTime;
	
	//public GameObject ScoreShow ;
	
	//public static int Score ;
	
	//public GameObject LifeShow;
	
	//public static int Life ;
	

	void Start () 
	{

	}

	void Update () 
	{
		MonsterFire -= 1 * Time.deltaTime;
		if (MonsterFire <= 0) 
		{
			int Produce = Random.Range(0,10);
			
			if(Produce == 5)
			{
				Instantiate (Monster, new Vector3 (393.2991f, -2.948914f, 587.3313f ), transform.rotation);
				
			}

			
			MonsterFire = MonsterFireTime;
		}

	}
}
