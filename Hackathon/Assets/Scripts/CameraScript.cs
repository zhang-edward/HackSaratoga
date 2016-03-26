using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	Camera cam;

	void Awake()
	{
		cam = Camera.main;
	}

	public void SetPosition(int size)
	{
		cam.orthographicSize = size;
		cam.transform.position = new Vector3(size, size / 2, -10);
	}
}
