using UnityEngine;
using System.Collections;


public class MenuScript : MonoBehaviour {

	public AudioClip Bell;
	public float GoNextLevel1;
	public float GoNextLevel2;
	public float GoNextLevel3;
	public float GoNextLevel4;
	public bool GoingToNextLevel1;
	public bool GoingToNextLevel2;
	public bool GoingToNextLevel3;
	public bool GoingToNextLevel4;

	void Start () {
	
	}

	void Update () {

		if (Input.GetKeyDown (KeyCode.W)) {
			audio.PlayOneShot (Bell, 1);
			GoingToNextLevel1 = true;
		}

		if (GoingToNextLevel1 == true) {
			GoNextLevel1 -= 1;
		}
	
		if(GoNextLevel1 < 0){
			Application.LoadLevel (1);

		}

		if (Input.GetKeyDown (KeyCode.A)) {
			audio.PlayOneShot (Bell, 1);
			GoingToNextLevel2 = true;
		}
		
		if (GoingToNextLevel2 == true) {
			GoNextLevel2 -= 1;
		}
		
		if(GoNextLevel2 < 0){
			Application.LoadLevel (2);

		}

		if (Input.GetKeyDown (KeyCode.S)) {
			audio.PlayOneShot (Bell, 1);
			GoingToNextLevel3 = true;
		}
		
		if (GoingToNextLevel3 == true) {
			GoNextLevel3 -= 1;
		}
		
		if(GoNextLevel3 < 0){
			Application.LoadLevel (3);
			
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			audio.PlayOneShot (Bell, 1);
			GoingToNextLevel4 = true;
		}
		
		if (GoingToNextLevel4 == true) {
			GoNextLevel4 -= 1;
		}
		
		if(GoNextLevel4 < 0){
			Application.LoadLevel (4);
			
		}
	}
}
