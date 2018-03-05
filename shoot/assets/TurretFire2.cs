using UnityEngine;
using System.Collections;

public class TurretFire2 : MonoBehaviour {

	public GameObject Monster ;

	public float MonsterFire;
	public float MonsterFireTime;
	

	
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
				Instantiate (Monster, new Vector3 (-456.2147f, 7.716751f,581 ), transform.rotation);
				
			}
			
			
			MonsterFire = MonsterFireTime;
		}
		
	}
}
