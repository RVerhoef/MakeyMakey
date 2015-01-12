using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	public AudioClip Countdown;
	public GUIText TimeText;
	public int TimeMin;
	public int TimeSec;
	public bool RoundStarted;
	public int MinusTimer;
	public AudioClip LoseSound;
	public GUIText HpText;
	public GUIText WinOrLoseText;
	public int StartHp;
	public bool IsHit;
	public AudioClip WinSound;
	public int CountdownTimer;
	public AudioClip Pain1;
	public AudioClip Pain2;
	public AudioClip Pain3;
	public int WhatPain;
	public AudioClip Punch1;
	public AudioClip Punch2;
	public AudioClip Punch3;
	public AudioClip Punch4;
	public AudioClip Punch5;
	public int WhatPunch;
	public int MaxHp;

	void Start () {

		audio.PlayOneShot (Countdown, 1);
	}

	void Update () {

		TimeText.text = TimeMin + ":" + TimeSec;

		CountdownTimer -= 1;

		if (CountdownTimer < 0) {
			RoundStarted = true;
			audio.PlayOneShot(WinSound,1);
			CountdownTimer = 99999999;
		}
		
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
			WinOrLoseText.text = "TIMEOUT! YOU LOSE!";
			audio.PlayOneShot(LoseSound,1);
		}

		HpText.text = "HP:" + StartHp + "/" + MaxHp;
		
		if (StartHp <= 0) {
			StartHp = 0;
		}
		
		if (IsHit == true && StartHp > 0 && RoundStarted == true) {
			StartHp -= Random.Range(1, 10);
			WhatPunch = Random.Range(1,6);
			if(WhatPunch == 1){
				audio.PlayOneShot(Punch1,2);
			}
			if(WhatPunch == 1){
				audio.PlayOneShot(Punch1,2);
			}
			if(WhatPunch == 2){
				audio.PlayOneShot(Punch2,2);
			}
			if(WhatPunch == 3){
				audio.PlayOneShot(Punch3,2);
			}
			if(WhatPunch == 4){
				audio.PlayOneShot(Punch4,2);
			}
			if(WhatPunch == 5){
				audio.PlayOneShot(Punch5,2);
			}
			WhatPain = Random.Range(1,4);
			if(WhatPain == 1){
				audio.PlayOneShot(Pain1,1);
				IsHit = false;
			}
			if(WhatPain == 2){
				audio.PlayOneShot(Pain2,1);
				IsHit = false;
			}
			if(WhatPain == 3){
				audio.PlayOneShot(Pain3,1);
				IsHit = false;
			}
		}
		
		if (StartHp == 0) {
			WinOrLoseText.text = "K.O.! YOU WON!";

			if(Input.anyKeyDown){
				Application.LoadLevel(0);
			}
		}

		if (Input.anyKeyDown) {
			IsHit = true;
		}
	}
}
