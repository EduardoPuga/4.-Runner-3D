using UnityEngine;
using System.Collections;

public class Pared : MonoBehaviour {
	
	void OnCollisionEnter (Collision col){
//		Debug.Log ("Trigger");
//		Debug.Log ("Name " + col.gameObject.name);
		if (col.gameObject.name == "Pilar(Clone)" || col.gameObject.name == "Tronco(Clone)" || col.gameObject.name == "Bush(Clone)" 
			|| col.gameObject.name == "Tree(Clone)" || col.gameObject.name == "Tree 2(Clone)" || col.gameObject.name == "Tree 3(Clone)") {
			Destroy (col.gameObject);
		}
	}
}
