using UnityEngine;
using System.Collections;

public class Seguimiento : MonoBehaviour {

	public GameObject[] players;
	public float separacion = 10f;
	private int index=0;

	public int anatomia = 1; // 1= humano; 2= aguila; 3= tigre; 4= roedor;

	void Start(){
		//updateIndex ();

	}

	// Update is called once per frame
	void Update () {
		//updateIndex ();
		//Debug.Log(" forma: " + index + " a " + players [index].name);
		transform.position = new Vector3 (transform.position.x , transform.position.y, players[index].transform.position.z - separacion);
	}

	public void updateIndex(int forma){
		Debug.Log("setting forma: " + index + " a " + players [index].name);

		players [index].SetActive (false);
		index=forma;
		players [index].SetActive (true);
		//index = anatomia-1;
		Debug.Log("nueva forma: " + index + " y es " + players [index].name);
	}
}
