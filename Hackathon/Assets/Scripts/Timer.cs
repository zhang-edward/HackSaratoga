using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

	public GameObject timeTF;
	public GameObject alertReference;

	void Start () {
		timeTF.GetComponent<Text>().text = "300";
		InvokeRepeating("ReduceTime", 1, 1);
		DontDestroyOnLoad(transform.gameObject);
	}
	void ReduceTime()
	{
		if (timeTF.GetComponent<Text>().text == "1")
		{
			Application.LoadLevel("gameover");
		}

		timeTF.GetComponent<Text>().text = (int.Parse(timeTF.GetComponent<Text>().text) - 1).ToString();
	}    
}