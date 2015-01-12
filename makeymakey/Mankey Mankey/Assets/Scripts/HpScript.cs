using UnityEngine;
using System.Collections;

public class HpScript : MonoBehaviour {

	public GUIText HpText;
	public GUIText Wintext;
	public int StartHp;
	public bool IsHit;
	public AudioClip WinSound;
	
	void Start () {
	
	}

	void Update () {

		HpText.text = "HP:" + StartHp + "/100";

		if (StartHp <= 0) {
			StartHp = 0;
		}

		if (IsHit == true && StartHp > 0) {
			StartHp -= Random.Range(1, 1);
			IsHit = false;
		}

		if (StartHp == 0) {
			Wintext.text = "K.O.! YOU WON!";
			audio.PlayOneShot(WinSound, 1);
		}
	}
}
