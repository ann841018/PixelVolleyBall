using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	int ScoreLeft;//左邊玩家的分數
	int ScoreRight;//右邊玩家的分數

	public GameObject[] ScoreLeft0 = new GameObject[3];//左邊玩家的十位數
	public GameObject[] ScoreLeft1 = new GameObject[10];//左邊玩家的個位數
	public GameObject[] ScoreRight0 = new GameObject[3];//右邊玩家的十位數
	public GameObject[] ScoreRight1 = new GameObject[10];//右邊玩家的十位數個位數

	Rigidbody2D BallRig;
	// Use this for initialization
	void Start () {
		BallRig = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (transform.position.y <= -2.4f||transform.position.x>7.5||transform.position.x<-7.5) {//球落地或出界
			BallRig.constraints = RigidbodyConstraints2D.FreezeAll;
			if (transform.position.x > 0) {//球在右邊落地
				ScoreLeft = ScoreLeft + 1;//左邊分數+1
				transform.position = new Vector3 (-4, 5, 0);//左邊玩家發球
			
			} else if (transform.position.x <0) {//球在左邊落地
				ScoreRight = ScoreRight + 1;//右邊分數+1
				transform.position = new Vector3 (4, 5, 0);//右邊玩家發球
			}
		}else BallRig.constraints = RigidbodyConstraints2D.None;






		for (int i = 0; i <= 2; i++) {
			if (i == ScoreLeft / 10)ScoreLeft0 [i].SetActive (true);else ScoreLeft0 [i].SetActive (false);
			if (i == ScoreRight / 10)ScoreRight0 [i].SetActive (true);else ScoreRight0 [i].SetActive (false);
		}

		for (int i = 0; i <= 9; i++) {
			if (i == ScoreLeft % 10)ScoreLeft1 [i].SetActive (true);else ScoreLeft1 [i].SetActive (false);
			if (i == ScoreRight % 10)ScoreRight1 [i].SetActive (true);else ScoreRight1 [i].SetActive (false);
		}

	}
}
