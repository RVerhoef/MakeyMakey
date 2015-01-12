using UnityEngine;
using System.Collections;

public class AnimScript : MonoBehaviour {

	public Animator Enemy;
	public int CountdownTimer;

	void Start () {
		Enemy = GetComponent<Animator>();
	}

	void Update () {

		CountdownTimer -= 1;

		if (CountdownTimer < 0){

		if (Input.GetKeyDown (KeyCode.W)) {
			Enemy.SetTrigger("HeadHit");
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			Enemy.SetTrigger("LSHit");
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			Enemy.SetTrigger("RSHit");
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			Enemy.SetTrigger("TorsoHit");
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			Enemy.SetTrigger("BuikHit");

			}
		}
	}
}
