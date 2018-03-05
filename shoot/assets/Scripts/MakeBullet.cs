using UnityEngine;
using System.Collections;

public class MakeBullet : MonoBehaviour {

	public GameObject obj_Bullet ;
	public float f_Time ;
	public float f_TimeToMath ;



	// Use this for initialization
	void Start () {
		f_Time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		f_Time += Time.deltaTime;
		if (Input.GetMouseButtonDown (0)) 
		{
			Fire() ;
		}
	}
	void Fire()
	{

		//可生成
		if (f_Time >= f_TimeToMath) 
		{
			GameObject obj_CloneBullet = Instantiate(obj_Bullet)as GameObject ;
			Vector3 Math_Point =Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.z,22));
			obj_CloneBullet.transform.position = Math_Point ;
		}

	}
}
