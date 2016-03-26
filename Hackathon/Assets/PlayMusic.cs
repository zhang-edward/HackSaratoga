using UnityEngine;
using System.Collections;

public class PlayMusic : MonoBehaviour {

	AudioSource source;

	void Awake()
	{
		source = GetComponent<AudioSource>();
	}

	void Start()
	{
		source.Play();
	}
}
