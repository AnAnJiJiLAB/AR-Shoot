using UnityEngine;
using System.Collections;

public class Monster2 : MonoBehaviour {

	public float MonsterSpeed ;
	//public GameObject MonsterBullet ;
	
	public float Monsterfire ;
	public float MonsterfireTime;
	
	public int MonsterScore ;
	
	public GameObject ScorePic ;
	
	
	// Use this for initialization
	void Start () 
	{
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Monsterfire -= 1 * Time.deltaTime;
		this.gameObject.transform.Translate (0, 0, MonsterSpeed * Time.deltaTime);
		
		if (Monsterfire <= 0) 
		{
			//Instantiate (MonsterBullet, transform.position, transform.rotation);
			//Instantiate (transform.position, transform.rotation);
			Monsterfire = MonsterfireTime;
		}
	}
	void OnTriggerEnter(Collider Catch)
	{
		if (Catch.gameObject.tag == "Bullet" )
		{
			GameContral.Score += MonsterScore ;
			Destroy(gameObject);
			Destroy(Catch.gameObject);
			Instantiate (ScorePic, transform.position, transform.rotation);
			
		}
		
	}
}
