using UnityEngine;
using System.Collections;

public class GridGenerator {

	public GridGenerator()
	{
<<<<<<< Updated upstream
=======
		
>>>>>>> Stashed changes
	}
	public bool[,]GenerateLevel(int focusLevel, int size)
	{
		bool[,] answer = new level[size][size];
		int count = size;
		for(int i = 0; i < count; i++)
		{
			int x = random.Range (0, size);
			int y = random.Range (0, size);

			answer [x, y] = true;
		}
		return answer;

	public bool[,] GenerateLevel(int focusLevel, int size)
	{
		bool[,] answer = new bool[size, size];
		return answer;
	}
}
