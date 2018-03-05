using UnityEngine;
using System.Collections;

public class Button2 : MonoBehaviour {

	public GUISkin BackMenu ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		GUI.skin = BackMenu;
		if (GUI.Button (new Rect (Screen.width / 2-130, Screen.height / 2, 100, 69), "")) 
		{
			Application.LoadLevel("Menu") ;
			
		}
		
		
		
	}
}
