using UnityEngine;
using System.Collections;

public class Turretbullet : MonoBehaviour {
	public float BulletSpeed ;
	//public float BulletKeepsec ;
	
	void Start () {
		
	}
	
	
	void Update () 
	{
		this.gameObject.transform.Translate (0, 0 ,-BulletSpeed * Time.deltaTime);
		Destroy(this.gameObject,10);
		
		
		
		
	}
}
