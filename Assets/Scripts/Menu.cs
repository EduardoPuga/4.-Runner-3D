using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	void OnGUI (){
		
		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height/1.8f, Screen.width / 5, Screen.height/ 10), "(S)TART") || Input.GetKeyDown(KeyCode.S)) {
			
			Application.LoadLevel("Game");
		}

		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height/1.5f, Screen.width / 5, Screen.height/ 10), "(I)NSTRUCTIONS") || Input.GetKeyDown(KeyCode.I)) {

			Application.LoadLevel("Instrucciones");
		}

		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height/1.29f, Screen.width / 5, Screen.height/ 10), "(E)XIT") || Input.GetKeyDown(KeyCode.E)) {
			
			Application.Quit();
		}
	}
}
