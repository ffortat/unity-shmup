using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
	public float m_cooldown = 1f;
	public Transform[] m_weapons;
	public Transform m_ammunition;

	private float m_timer = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Shoot(bool fire) {
		if (fire) {
			if (m_timer >= m_cooldown) {
				m_timer = 0f;

				foreach (Transform weapon in m_weapons) {
					Transform ammunition = (Transform)Instantiate(m_ammunition);
					ammunition.position = weapon.position;
				}
			}

		}

		m_timer += Time.deltaTime;
	}
}
