using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Use this for initialization
	public Rigidbody rb;
	[SerializeField]
	float power;
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) 
		{	
			rb.AddForce(Vector3.forward *  power );
			AudioSource source = GetComponent<AudioSource>();
			source.Play();
		}

	}
}
