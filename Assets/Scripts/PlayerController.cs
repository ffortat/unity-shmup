using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float m_maxSpeed = 1f;

	private Rigidbody2D m_rigidbody;

	// Use this for initialization
	void Start() {
		m_rigidbody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update() {
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");
		bool fire = Input.GetButton("Fire1");

		//m_rigidbody.velocity = new Vector2(x, y) * m_maxSpeed;
		m_rigidbody.MovePosition(m_rigidbody.position + new Vector2(x, y) * m_maxSpeed * Time.deltaTime);
	}
}
