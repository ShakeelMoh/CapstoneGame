using UnityEngine;
using System.Collections;

//This script allows both players to be in view of the camera at all times
public class MultiplayerCamera: MonoBehaviour {
	public Transform Player1, Player2;
	public float minSizeY = 5f;

	void SetCameraPos() {
		Vector3 middle = Player1.position + Player2.position * 0.5f;

		gameObject.GetComponent<Camera>().transform.position = new Vector3(
			gameObject.GetComponent<Camera>().transform.position.x,
			middle.y,
			middle.z
		);
	}

	void SetCameraSize() {
		//horizontal size is based on actual screen ratio
		float minSizeX = minSizeY * Screen.width / Screen.height;

		//multiplying by 0.5, because the ortographicSize is actually half the height
		float width = Mathf.Abs(Player1.position.x - Player2.position.x) * 0.5f;
		float height = Mathf.Abs(Player1.position.y - Player2.position.y) * 0.5f;

		//computing the size
		float camSizeX = Mathf.Max(width, minSizeX);
		gameObject.GetComponent<Camera>().orthographicSize = Mathf.Max(height, camSizeX * Screen.height / Screen.width, minSizeY);
	}

	void Update() {
		SetCameraPos();
		SetCameraSize();
	}
}