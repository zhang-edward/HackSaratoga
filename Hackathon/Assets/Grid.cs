using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public int size;
	public bool[,] grid;
	public GameObject[,] tileGrid;
	//public bool isBlack;
	private GridGenerator generator;

	public GameObject tile;
	public GameObject tile2;

	public bool levelComplete;

	void Start()
	{
		transform.position = new Vector3 (size / 2, size / 2, 0);

		tileGrid = new GameObject[size, size];
		Init ();
		generator = new GridGenerator();
	}

	public void GenerateLevel(int focusLevel)
	{
		updateColorGrid();
		if (Input.GetMouseButton (0)){
			//return position of mouse
		}

	}

	public void Init()
	{
		for (int row = 0; row < size; row++) {
			for (int col = 0; col < size; col++) {
				GameObject o = Instantiate (tile) as GameObject;
				GameObject p = Instantiate (tile2) as GameObject;
				o.transform.position = new Vector2 (col, row);
				p.transform.position = new Vector2 (col, row);
				tileGrid[row, col] = o;
				if (updateColorGrid) 
				{
					
					tileGrid[row, col] = p;
				}
			}
		}
	}

/*
	public void newGrid()
	{
		grid = new bool[size,size];
		for (int row = 0; row < size; row++) 
		{
			for (int col = 0; col < size; col++) 
			{
				grid [row, col] = false;
			}
		}
	}
*/
		
	public void bool updateColorGrid(int row, int col)
	{
		grid [row, col] = !grid [row, col];
	}

}
