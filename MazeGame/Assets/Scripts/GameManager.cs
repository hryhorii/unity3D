using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

	// Use this for initialization
	public Text score;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score:" + GlobalClass.Instance.score;

		if (Input.GetKeyDown (KeyCode.Escape)) {
			GlobalClass.Instance.isGameOver = true;
			GlobalClass.Instance.gameOverReason = 2;
		}
		if (GlobalClass.Instance.isGameOver) {
			SceneManager.LoadScene ("GameOver");
		}
	}
}
