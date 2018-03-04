using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public PlayerController m_playerController;
	public Spawner m_spawner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (m_playerController.IsDead()) {
			// TODO Lose
			Debug.Log("Game Over");
		}

		if (m_spawner.IsOver()) {
			// TODO Win
			Debug.Log("You Win !");
		}
	}
}
