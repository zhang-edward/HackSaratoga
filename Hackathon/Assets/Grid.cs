using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	public bool[,] grid;
	private GridGenerator generator;

	void Start()
	{
		generator = new GridGenerator();
	}

	void Update()
	{

	}
}
