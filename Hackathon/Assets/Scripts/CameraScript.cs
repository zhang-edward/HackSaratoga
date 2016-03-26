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
		cam.orthographicSize = size + 1;
		transform.position = new Vector3(size / 2, size / 2, -10);
	}
}
