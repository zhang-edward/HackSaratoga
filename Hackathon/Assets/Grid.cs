using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public int size;
	public bool[,] grid;
	private GridGenerator generator;

	public bool levelComplete;

	void Start()
	{
		generator = new GridGenerator();
	}

	public void GenerateLevel(int focusLevel)
	{
	}
}
