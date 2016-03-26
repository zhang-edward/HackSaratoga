using UnityEngine;
using System.Collections;

public class GridGenerator {

	public GridGenerator()
	{
	}
	public bool[,] GenerateLevel(int focusLevel, int size)
	{
		bool[,] answer = new bool[size, size];
		int count = 5;
		for (int i = 0; i < count; i++)
		{
			int x = Random.Range(0, size);
			int y = Random.Range(0, size);

			answer[x, y] = !answer[x, y];
		}
		return answer;
	}
}
