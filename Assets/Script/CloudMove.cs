using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour {

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate(0.05f,0,0);
		if(transform.position.x >= 10f){
			transform.position = new Vector3(-10f, Random.Range(1,5),0);
		}
	}
}
