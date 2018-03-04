﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public Wave[] m_waves;

	private Vector2 m_position;
	private int m_currentWave;
	private float m_timer;
	private float m_spawnTimer;
	private bool m_over;

	// Use this for initialization
	void Start () {
		m_position = transform.position;

		m_currentWave = 0;
		m_timer = 0f;
		m_spawnTimer = 0f;
		m_over = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!m_over && m_waves[m_currentWave].duration <= m_timer) {
			m_currentWave += 1;
			m_timer = 0f;
			m_over = m_currentWave >= m_waves.Length;
		}

		if (!m_over) {
			if (m_spawnTimer <= 0f) {
				m_spawnTimer = m_waves[m_currentWave].spawnDelay;

				foreach (SpawnLocation location in m_waves[m_currentWave].spawnLocations) {
					if (location.quantity > 0) {
						Transform enemy = (Transform)Instantiate(location.enemy);
						enemy.position = m_position + location.location;

						location.quantity -= 1;
					}
				}
			}

			m_spawnTimer -= Time.deltaTime;
		}

		m_timer += Time.deltaTime;
	}
}
