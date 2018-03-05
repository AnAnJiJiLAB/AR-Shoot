using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public Transform Player ;
	public float PlayerSpeed ;
	Vector3 EedPosittion ;
	public GameObject Bullet ;
	float Fire ;
	public float FireTime ;

	// Use this for initialization
	void Start () 
	{
		Fire = 0;


	}
	
	// Update is called once per frame
	void Update () 
	{
		Fire -= 1 * Time.deltaTime;

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Input.GetMouseButton (0)) 
		{
		
			if (Physics.Raycast (ray, out hit)) 
			{
				if (hit.collider.gameObject.name == "PlayTouch") 
				{
					EedPosittion = hit.point;
					if(Fire <= 0)
					{
					Instantiate (Bullet, transform.position, transform.rotation);
						Fire = FireTime ;
					}
				}

			}
		if (EedPosittion != Player.transform.position) {
		
				Player.position = Vector3.MoveTowards (Player.position, new Vector3 (EedPosittion.x, 0, EedPosittion.z), PlayerSpeed * Time.deltaTime);
		
			}
		}
	}
	void OnTriggerEnter(Collider Catch)
	{
		if (Catch.gameObject.tag == "Monster Bullet" || Catch.gameObject.tag == "Monster")
		{
			GameContral.Life -=1 ;
			if (GameContral.Life == 0)
			{

				Destroy(gameObject);
				//Application.LoadLevel("SP4");

			}

			Destroy(Catch.gameObject);
			
		}
		
	}

}
