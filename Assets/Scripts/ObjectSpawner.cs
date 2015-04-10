using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour {

	public GameObject m_ObjectPrefab;
	public float m_SpawnRateInSeconds = 3000.0f;
	public ObjectMover.Direction m_Direction;

	public float m_TimeCountDown = 0;

	// Use this for initialization
	void Start () {
		SpawnObject();	
		m_TimeCountDown = m_SpawnRateInSeconds;
	}
	
	// Update is called once per frame
	void Update () {
		m_TimeCountDown -= Time.deltaTime;
		if (m_TimeCountDown <= 0.0f) {
			m_TimeCountDown = m_SpawnRateInSeconds;
			SpawnObject();
		}
	
	}

	void SpawnObject () {
		Quaternion objectRotation = Quaternion.Euler(0, (m_Direction == ObjectMover.Direction.Forward) ? 0 : 180, 0);
		GameObject spawnedObject = GameObject.Instantiate(m_ObjectPrefab, transform.position, objectRotation) as GameObject;
		ObjectMover spawnedObjectMover = spawnedObject.GetComponent<ObjectMover>();
		spawnedObjectMover.m_Direction = m_Direction;
	}
}
