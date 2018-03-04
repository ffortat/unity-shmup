using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {
	public float m_sinAmplitude = 1f;
	public float m_sinSpeed = 1f;
	public float m_speed = 1f;

	private float m_timer;
	private bool m_entered;

	private Renderer m_renderer;
	private Rigidbody2D m_rigidbody;
	private Weapon m_weapon;
	private Spawner m_spawner;
	private Vector2 m_initialPosition;

	// Use this for initialization
	void Start () {
		m_timer = 0;
		m_entered = false;

		m_renderer = GetComponent<Renderer>();
		m_rigidbody = GetComponent<Rigidbody2D>();
		m_weapon = GetComponent<Weapon>();
		m_initialPosition = m_rigidbody.position;
	}

	// Update is called once per frame
	void Update () {
		m_rigidbody.MovePosition(new Vector2(m_initialPosition.x + Mathf.Sin(m_timer * m_sinSpeed * 2 * Mathf.PI) * m_sinAmplitude / 2, m_rigidbody.position.y - m_speed * Time.deltaTime));

		if (m_renderer.isVisible) {
			if (!m_entered) {
				m_entered = true;
			}

			m_weapon.Shoot(true);
		} else {
			if (m_entered) {
				Kill();
				Destroy(gameObject);
			}
		}

		m_timer += Time.deltaTime;
	}

	public void AssignSpawner(Spawner spawner) {
		m_spawner = spawner;
	}

	public void Kill() {
		if (m_spawner) {
			m_spawner.RemoveEnemy(transform);
		}
	}
}
