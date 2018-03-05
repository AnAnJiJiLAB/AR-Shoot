using UnityEngine;
using System.Collections;

public class Gamecontral5 : MonoBehaviour 
{

	public GameObject Monster ;
	public GameObject Monster2 ;
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
				Instantiate (Monster, new Vector3 (709, 65, -2), transform.rotation);
				
			}
			if(Produce == 1)
			{
				Instantiate (Monster2, new Vector3 (709, 65, -2), transform.rotation);


			}
			/*if(Produce == 2)
			{
				Instantiate (Monster, new Vector3 (0, 75, -393), transform.rotation);
				
			}
			if(Produce == 3)
			{
				Instantiate (Monster, new Vector3 (566, 75, -5), transform.rotation);
				
			}*/
			/*if(Produce == 4)
			{
				Instantiate (Monster, new Vector3 (-6.39f, 0, 3), transform.rotation);
				
			}*/
			//Instantiate (Monster, new Vector3 (0, 0, 3), transform.rotation);
			MonsterFire = MonsterFireTime;
		}
		
	/*	ScoreShow.guiText.text = "" + Score;
		LifeShow.guiText.text = "" + Life;*/
		
	}
}
