using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public int size;
	public bool[,] grid;
	public bool[,] template;
	public GameObject[,] tileGrid;
	//public bool isBlack;
	private GridGenerator generator;

	public GameObject tile;

	public bool levelComplete;

	void Start()
	{
		grid = new bool[size, size];
		tileGrid = new GameObject[size, size];
		Init ();
		generator = new GridGenerator();
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Debug.Log(mousePosition);
			updateColorGrid(Mathf.RoundToInt(mousePosition.y), Mathf.RoundToInt(mousePosition.x));
		}

		for (int x = 0; x < size; x ++)
		{
			for (int y = 0; y < size; y ++)
			{
				if (grid[y, x])
					tileGrid[y, x].GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f);
				else
					tileGrid[y, x].GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
			}
		}
	}

	public void GenerateLevel(int focusLevel)
	{
		size = focusLevel;
	}

	public void Init()
	{
		for (int row = 0; row < size; row++) {
			for (int col = 0; col < size; col++) {
				GameObject o = Instantiate (tile) as GameObject;
				o.transform.position = new Vector2 (col, row);
				tileGrid[row, col] = o;
			}
		}
	}
	
	public void updateColorGrid(int row, int col)
	{
		grid [row, col] = !grid [row, col];
	}

}
