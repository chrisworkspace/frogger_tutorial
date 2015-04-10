using UnityEngine;
using System.Collections;

public class WaterKillBox : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		if (!other.gameObject.GetComponent<PlayerMovement>()) {
			return;
		}

		if (other.transform.parent != null) {
			return;
		}

		Debug.Log("Object entered water kill box");
		Application.LoadLevel(0);
		//Destroy(other.gameObject);
	}	
}
