using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	public float BulletSpeed ;
	//public float BulletKeepsec ;

	void Start () {
	
	}
	

	void Update () 
	{
		this.gameObject.transform.Translate (0, -BulletSpeed * Time.deltaTime ,0);
		Destroy(this.gameObject,3);
		



	}
}
