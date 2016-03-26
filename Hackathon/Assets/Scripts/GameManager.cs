using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public CameraScript cam;
	public int focusLevel;
	public Grid grid;
	public Grid template;

	void Start()
	{
		cam.SetPosition(grid.size);
		LoadNextLevel();
	}
	
	// Update is called once per frame
	void Update () {
		if (isEqual(grid.grid, template.grid))
		{
			LoadNextLevel();
		}
	}

	public void LoadNextLevel()
	{
		cam.SetPosition(grid.size);
		grid.Init();
		template.GenerateLevel(grid.size);
		template.acceptsInput = false;
		template.transform.position = new Vector2(grid.size + 1, 0);
	}

	public bool isEqual(bool[,] one, bool[,] two)
	{
		for (int x = 0; x < one.GetLength(0); x ++)
		{
			for (int y = 0; y < one.GetLength(1); y ++)
			{
				if (one[y, x] != two[y, x])
					return false;
			}
		}
		Debug.Log("equals");
		return true;
	}
}

