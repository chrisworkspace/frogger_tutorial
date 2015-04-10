using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// improve: better to cache the transform
		var position = transform.position;
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			transform.parent = null;
			position.z += -1;
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			position.z += 1;
		} else if (Input.GetKeyDown(KeyCode.RightArrow)) {
			position.x += -1;
		} else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			position.x += 1;
		}

		// improve: no need to assign when there is no input
		transform.position = position;
	}

	void OnTriggerEnter(Collider other) {
		if (!other.gameObject.CompareTag("board")) {
			return;
		}

		Vector3 playerPosition = transform.position;
		Vector3 boardPosition = other.transform.position;

		if (playerPosition.x < other.bounds.max.x && playerPosition.x > other.bounds.min.x) {
			transform.parent = other.transform;
			Debug.Log("In Bounds");
		} else {
			Application.LoadLevel(0);
			//Destroy(gameObject);
		}
	}
}
