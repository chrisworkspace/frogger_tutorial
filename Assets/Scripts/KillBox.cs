using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]

public class KillBox : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		if (!other.gameObject.GetComponent<PlayerMovement>()) {
			return;
		}

		Debug.Log("Object entered kill box");
		Application.LoadLevel(0);
		//Destroy(other.gameObject);
	}
}
