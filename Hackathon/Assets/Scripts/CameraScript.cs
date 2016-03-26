using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	Camera cam;

	void Awake()
	{
		cam = GetComponent<Camera>();
	}

	void Update()
	{
		SetPosition();
	}

	public void SetPosition()
	{
		cam.orthographicSize = GameManager.instance.grid.size;
		cam.transform.position = new Vector3(GameManager.instance.grid.size, GameManager.instance.grid.size / 2, -10);
	}
}
