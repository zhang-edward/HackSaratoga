using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	public Text timeText;
	
	// Update is called once per frame
	void Update () {
		float timer = GameManager.instance.timer;
		int minutes = (int)timer / 60;
		int seconds = (int)timer % 60;

		string strsec = "" + seconds;
		if (seconds < 10)
			strsec = "0" + strsec;
		timeText.text = "(Demo) Timer: " + minutes + ":" + strsec;
	}
}
