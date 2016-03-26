using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int focusLevel;
	public Grid grid;

	void Start()
	{
	}
	
	// Update is called once per frame
	void Update () {
		if (grid.levelComplete)
		{
			LoadNextLevel();
		}
	}

	public void LoadNextLevel()
	{

	}
}
