using UnityEngine;
using System.Collections;

public class Game_controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI () {
		if (GUI.Button (new Rect (Screen.width/2-75,Screen.height/2-50,150,100), "start")) {
			Application.LoadLevel(1);	//replace print start with application.loadlevel "Whatismylevelsname"
		}
	}
}
