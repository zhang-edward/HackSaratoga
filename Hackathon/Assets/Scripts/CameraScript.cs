using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	Camera cam;

	void Awake()
	{
		cam = GetComponent<Camera>();
	}

	public void SetPosition(int size)
	{
		cam.orthographicSize = size;
		transform.position = new Vector3(size, size / 2, -10);
	}
}
