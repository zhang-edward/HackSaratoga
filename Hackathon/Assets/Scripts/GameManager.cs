using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public CameraScript cam;
	public int focusLevel;
	public Grid grid;

	void Start()
	{
		cam.SetPosition(grid.size);
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
		cam.SetPosition(grid.size);
		grid.Init();
	}
}
