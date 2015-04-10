using UnityEngine;
using System.Collections;

public class LevelComplete : MonoBehaviour {

	private string m_LevelCompleteText = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (!other.gameObject.GetComponent<PlayerMovement>()) {
			return;
		}
		m_LevelCompleteText = "You Completed The Level!!";
	}

	void OnGUI() {
		GUI.Label(new Rect(10, 10, 300, 20), m_LevelCompleteText);
	}
}
