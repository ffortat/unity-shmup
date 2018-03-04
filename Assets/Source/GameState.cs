using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {
	private bool m_gameWin;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);

		m_gameWin = false;
		SceneManager.LoadScene("menu");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetWin(bool win) {
		m_gameWin = win;
	}

	public bool HasWon() {
		return m_gameWin;
	}
}
