using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammunition : MonoBehaviour {
	public Vector2 m_velocity;
	public float m_damage = 10f;

	private Rigidbody2D m_rigidbody;

	// Use this for initialization
	void Start () {
		m_rigidbody = GetComponent<Rigidbody2D>();
		m_rigidbody.velocity = m_velocity;
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log("I triggered");
		
		Health health = other.GetComponent<Health>();

		if (health) {
			health.Hit(m_damage);
		}

		Destroy(gameObject);
	}
}
