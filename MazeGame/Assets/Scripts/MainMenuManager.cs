using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour {

	// Use this for initialization
	public Text playerName;
	void Start () {
		playerName.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}
	}
	public void StartGame()
	{
		GlobalClass.Instance.playerName = playerName.text;
		SceneManager.LoadScene ("1");
	}
	public void ShowScores()
	{
		SceneManager.LoadScene ("HighestScore");
	}
}
