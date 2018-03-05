using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public GameObject Bullet ;
	float Fire ;
	public float FireTime ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButton (0)) {
			Fire -= 1 * Time.deltaTime;
			Instantiate (Bullet, transform.position, transform.rotation);
			Fire = FireTime;

		}

	}
}
