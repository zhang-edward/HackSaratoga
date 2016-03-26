using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public bool acceptsInput;

	public int size;
	public bool[,] grid;
	public GameObject[,] tileGrid;
	//public bool isBlack;
	private GridGenerator generator;

	public GameObject tile;

	public bool levelComplete;

	void Awake()
	{
		grid = new bool[size, size];
		tileGrid = new GameObject[size, size];
		generator = new GridGenerator();
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0) && acceptsInput)
		{
			Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			int y = Mathf.RoundToInt(mousePosition.y);
			int x = Mathf.RoundToInt(mousePosition.x);
			if (isInBounds(y, x))
				updateColorGrid(y, x);
		}

		for (int x = 0; x < size; x ++)
		{
			for (int y = 0; y < size; y ++)
			{
				//Debug.Log(grid[y, x]);
				if (grid[y, x])
					tileGrid[y, x].GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f);
				else
					tileGrid[y, x].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
			}
		}
	}

	public void resetSize(int size)
	{
		foreach (GameObject o in tileGrid)
			Destroy(o);
		this.size = size;
		grid = new bool[size, size];
	}

	public void GenerateLevel(int focusLevel)
	{
		size = focusLevel;
		grid = generator.GenerateLevel(focusLevel, size);
		Init();
	}

	public void Init()
	{
		for (int row = 0; row < size; row++) {
			for (int col = 0; col < size; col++) {
				GameObject o = Instantiate (tile) as GameObject;
				o.transform.parent = this.transform;
				o.transform.localPosition = new Vector2 (col, row);
				tileGrid[row, col] = o;
			}
		}
	}
	
	public void updateColorGrid(int row, int col)
	{
		grid [row, col] = !grid [row, col];
	}

	public bool isInBounds(int x, int y)
	{
		if (x >= 0 && y >= 0 &&
			x < size && y < size)
			return true;
		else
			return false;
	}
}
