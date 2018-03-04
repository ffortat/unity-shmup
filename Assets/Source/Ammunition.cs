using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammunition : MonoBehaviour {
	public Vector2 m_velocity;
	public float m_damage = 10f;
	public bool m_persist = false;

	private Rigidbody2D m_rigidbody;

	// Use this for initialization
	void Start () {
		m_rigidbody = GetComponent<Rigidbody2D>();
		m_rigidbody.velocity = m_velocity;
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		Health health = other.GetComponent<Health>();

		if (health) {
			health.Hit(m_damage);
		}

		if (!m_persist) {
			Destroy(gameObject);
		}
	}
}
