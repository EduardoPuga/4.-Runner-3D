using UnityEngine;
using System.Collections;

public class Instrucciones : MonoBehaviour {
	
	void OnGUI (){
		
		if (GUI.Button (new Rect (Screen.width / 1.30f /*posicion horizontal*/, Screen.height / 1.2f/*posicion vertical*/,
			Screen.width / 5/*tamaño en relacion a x*/, Screen.height / 10/*tamaño en relacion a y*/), "(S)TART") || Input.GetKeyDown(KeyCode.S)) {
			
			Application.LoadLevel("Game");
		}

		if (GUI.Button (new Rect (Screen.width / 15f /*posicion horizontal*/, Screen.height / 1.2f/*posicion vertical*/,
			Screen.width / 5/*tamaño en relacion a x*/, Screen.height / 10/*tamaño en relacion a y*/), "(B)ACK") || Input.GetKeyDown(KeyCode.B)) {
			
			Application.LoadLevel("Menu");
		}
	}
}
