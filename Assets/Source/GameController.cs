using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public PlayerController m_playerController;
	public Spawner m_spawner;

	private GameState m_gameState;

	// Use this for initialization
	void Start () {
		m_gameState = FindObjectOfType<GameState>();
	}

	// Update is called once per frame
	void Update () {
		if (m_playerController.IsDead()) {
			m_gameState.SetWin(false);
			SceneManager.LoadScene("endgame");
		}

		if (m_spawner.IsOver()) {
			m_gameState.SetWin(true);
			SceneManager.LoadScene("endgame");
		}
	}
}
