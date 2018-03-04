using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {
	public float m_sinAmplitude = 1f;
	public float m_sinSpeed = 1f;
	public float m_speed = 1f;

	private float m_timer;

	private Renderer m_renderer;
	private Rigidbody2D m_rigidbody;
	private Weapon m_weapon;
	private Vector2 m_initialPosition;

	// Use this for initialization
	void Start () {
		m_timer = 0;

		m_renderer = GetComponent<Renderer>();
		m_rigidbody = GetComponent<Rigidbody2D>();
		m_weapon = GetComponent<Weapon>();
		m_initialPosition = m_rigidbody.position;

		Debug.Log(m_initialPosition);
	}

	// Update is called once per frame
	void Update () {
		m_rigidbody.MovePosition(new Vector2(m_initialPosition.x + Mathf.Sin(m_timer * m_sinSpeed * 2 * Mathf.PI) * m_sinAmplitude / 2, m_rigidbody.position.y - m_speed * Time.deltaTime));

		if (m_renderer.isVisible) {
			m_weapon.Shoot(true);
		}

		m_timer += Time.deltaTime;
	}
}
