using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
	public float m_healthPoints = 1f;

	private float m_currentHealth = 0f;

	// Use this for initialization
	void Start () {
		m_currentHealth = m_healthPoints;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Hit(float damage) {
		if (m_currentHealth > 0f) {
			m_currentHealth -= damage;

			if (m_currentHealth <= 0f) {
				Destroy(gameObject);
			}
		}
	}

	public void Heal(float heal) {
		if (m_currentHealth > 0f) {
			m_currentHealth = Mathf.Min(m_healthPoints, m_currentHealth + heal);
		}
	}
}
