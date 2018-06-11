using UnityEngine;
using System.Collections;

public class Final : MonoBehaviour {
	
	void OnGUI (){
		
		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height/1.8f, Screen.width / 5, Screen.height/ 10), "(R)ESTART") || Input.GetKeyDown(KeyCode.R)) {
			
			Application.LoadLevel("Game");
		}

		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height/1.5f, Screen.width / 5, Screen.height/ 10), "(M)ENU") || Input.GetKeyDown(KeyCode.M)) {

			Application.LoadLevel("Menu");
		}

		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height/1.29f, Screen.width / 5, Screen.height/ 10), "(E)XIT") || Input.GetKeyDown(KeyCode.E)) {
			
			Application.Quit();
		}
	}
}
