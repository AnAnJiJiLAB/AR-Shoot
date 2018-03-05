using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour 

{
	public GUISkin MenuStart ;
	// Use this for initialization
	void Start () 
	{
	


	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	void OnGUI()
	{
		GUI.skin = MenuStart;
		if (GUI.Button (new Rect (Screen.width / 2-100, Screen.height / 2, 100, 69), "")) 
		{
			Application.LoadLevel("SH") ;
			
		}



	}

}



