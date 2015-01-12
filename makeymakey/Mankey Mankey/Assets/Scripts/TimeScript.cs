using UnityEngine;
using System.Collections;

public class TimeScript : MonoBehaviour {

	public GUIText TimeText;
	public GUIText LoseText;
	public int TimeMin;
	public int TimeSec;
	public bool RoundStarted;
	public int MinusTimer;
	public AudioClip LoseSound;

	void Start () {
	
	}

	void Update () {

		TimeText.text = TimeMin + ":" + TimeSec;

		if (TimeSec == 0 && TimeMin > 0){
			TimeMin -= 1;
			TimeSec += 60;
		}

		if (RoundStarted == true) {
			MinusTimer -= 1;
		}

		if (MinusTimer == 0 && TimeSec > 0){
			MinusTimer = 100;
			TimeSec -= 1;
		}

		if (TimeMin == 0 && TimeSec == 0){
			LoseText.text = "TIMEOUT! YOU LOSE!";
			audio.PlayOneShot(LoseSound,1);
		}
	}
}
