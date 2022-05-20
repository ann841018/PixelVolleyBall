using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anan : MonoBehaviour {

	Animator myAnim;
	Rigidbody2D myRig;

	// Use this for initialization
	void Start () {
		myAnim = GetComponent<Animator> ();
		myRig = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.LeftArrow)) 
		{
			transform.Translate (-0.1f, 0, 0);
			myAnim.SetBool("Left",true);
		}else myAnim.SetBool("Left",false);

		if (Input.GetKey(KeyCode.RightArrow)) 
		{
			transform.Translate (0.1f, 0, 0);
			myAnim.SetBool("Right",true);
		}else myAnim.SetBool ("Right", false);

		if (transform.position.y < -1.5) {
			if (Input.GetKeyDown (KeyCode.RightShift)) {
				myRig.AddForce (new Vector2 (0, 500));
			}
		}

	}
}
