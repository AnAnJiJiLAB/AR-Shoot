using UnityEngine;
using System.Collections;

public class GameContral2 : MonoBehaviour 
{
	public GameObject Monster ;
	public GameObject Monster2 ;
	//public GameObject Monster2 ;
	public float MonsterFire;
	public float MonsterFireTime;
	
	public GameObject ScoreShow ;
	
	public static int Score ;
	
	public GameObject LifeShow;
	
	public static int Life ;
	
	//
	
	
	
	
	// Use this for initialization
	void Start () 
	{
		/*Score = 0;
		Life = 3;*/
	}
	
	// Update is called once per frame
	void Update () 
	{
		MonsterFire -= 1 * Time.deltaTime;
		if (MonsterFire <= 0) 
		{
			int Produce = Random.Range(0,20);
			
			if(Produce == 4)
			{
				Instantiate (Monster, new Vector3 (646, 65, 500 ), transform.rotation);
				
			}
			if(Produce == 1)
			{
				Instantiate (Monster2, new Vector3 (646, 65, 500), transform.rotation);
				
				
			}

			MonsterFire = MonsterFireTime;
		}
		
		/*ScoreShow.guiText.text = "" + Score;
		LifeShow.guiText.text = "" + Life;*/
		
	}
}
