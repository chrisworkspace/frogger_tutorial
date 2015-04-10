using UnityEngine;
using System.Collections;

public class ObjectMover : MonoBehaviour {
	public enum Direction { Forward, Reverse };
	public Direction m_Direction;
	public int m_SpeedMultiplier = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () {
		var position = transform.position;	
		position.x += ((m_Direction == Direction.Forward) ? -0.05f : 0.05f) * m_SpeedMultiplier;
		transform.position = position;
	}

	void OnTriggerExit(Collider other) {
		Destroy(this.gameObject);
	}

	void OnDrawGizmos() {
//		Gizmos.color = Color.yellow;
//		Gizmos.DrawWireSphere(transform.position, 0.5f);
		Collider collider = gameObject.GetComponent<Collider>();
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(collider.bounds.max, 0.3f);
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(collider.bounds.min, 0.3f);
	}
}
