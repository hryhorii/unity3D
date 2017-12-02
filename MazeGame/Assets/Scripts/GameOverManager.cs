using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverManager : MonoBehaviour {

	// Use this for initialization
	public Text lastScore,reason,highestScoreText;
	void Start () {
		SaveData ();
		lastScore.text = "Last Score:"+GlobalClass.Instance.score.ToString ();
		if (GlobalClass.Instance.gameOverReason == 1)
			reason.text = "Game Over reason: Dead";
		else
			reason.text = "Game Over Reason: Escaped";

		ResetData ();

	}
	
	// Update is called once per frame
	void Update () {

	}
	public void GoHome()
	{
		SceneManager.LoadScene ("MainMenu");
	}
	public void Restart()
	{
		SceneManager.LoadScene ("1");
	}
	public void SaveData()
	{
		int records = 0;
		int highestScore = 0;
		if (PlayerPrefs.HasKey ("noOfRecords"))
			records=PlayerPrefs.GetInt ("noOfRecords");
		if(PlayerPrefs.HasKey("HighestScore"))
			highestScore=PlayerPrefs.GetInt("HighestScore");
		if (GlobalClass.Instance.score > highestScore) {
			highestScore = GlobalClass.Instance.score;
			PlayerPrefs.SetInt ("HighestScore", GlobalClass.Instance.score);
		}
		PlayerPrefs.SetString("RecordName"+records,GlobalClass.Instance.playerName);
		PlayerPrefs.SetInt("RecordScore"+records,GlobalClass.Instance.score);
		PlayerPrefs.SetInt("RecordGoReason"+records,GlobalClass.Instance.gameOverReason);
		PlayerPrefs.SetString ("RecordTime" + records, System.DateTime.Now.ToString ());

		PlayerPrefs.SetInt ("noOfRecords", records + 1);
		PlayerPrefs.Save ();
		highestScoreText.text = "Highest Score:" + highestScore.ToString ();
	}
	public void ResetData()
	{
		GlobalClass.Instance.coins = 0;
		GlobalClass.Instance.score = 0;
		GlobalClass.Instance.gameOverReason = 1;
		GlobalClass.Instance.isGameOver = false;
	}
}
