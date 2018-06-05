using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

	public GameObject [] obstaculo;
	public float tiempoMin = 1.5f;
	public float tiempoMax = 3f;


	// Use this for initialization
	void Start () {

		metodo ();

	}

	// Update is called once per frame
	void Update () {

	}

	void metodo(){
		Invoke ("Generar", Random.Range (tiempoMin, tiempoMax));
	}

	void Generar() {
		Instantiate(obstaculo[Random.Range(0,obstaculo.Length)], transform.position, Quaternion.identity);
		metodo ();
	}
}