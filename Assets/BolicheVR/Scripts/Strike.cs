using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strike : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Bola (2)")
		{
			AudioSource source = GetComponent<AudioSource>();
			source.Play();
			Debug.Log("Bienvenido Jugador1");
		}
	}
}
