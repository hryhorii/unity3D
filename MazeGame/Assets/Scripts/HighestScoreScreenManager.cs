using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HighestScoreScreenManager : MonoBehaviour {

	// Use this for initialization
	public Transform parentPanel;
	public GameObject childPanel;
	public Text highestScore;

	public Text name1,name2,name3,name4,name5;
	public Text score1,score2,score3,score4,score5;
	public Text reason1,reason2,reason3,reason4,reason5;
	public Text date1,date2,date3,date4,date5;
	private int currentIndex=1,maxRecords;
	//public GameObject childPanel;

	void Start () {
		if (PlayerPrefs.HasKey ("HighestScore"))
			highestScore.text = "Highest Score:"+PlayerPrefs.GetInt ("HighestScore").ToString ();
		if (PlayerPrefs.HasKey ("noOfRecords")) {
			maxRecords = PlayerPrefs.GetInt ("noOfRecords");
		}
		PopulateScores ();
		GetScores (currentIndex);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void PopulateScores()
	{
		int maxRecords;
		if(PlayerPrefs.HasKey("noOfRecords"))
		{
		maxRecords = PlayerPrefs.GetInt ("noOfRecords");
			for (int i = 0; i <= maxRecords; i++) {
				GameObject a = Instantiate (childPanel); 
				//GameObject a=Instantiate(childPanel, new Vector3(childPanel.transform.position.x, childPanel.position.y+146, 0), Quaternion.identity);
				a.transform.SetParent (parentPanel.transform, false);

				ScorePanel b = childPanel.GetComponent<ScorePanel> ();
				b.nameT.text = PlayerPrefs.GetString ("RecordName" + i.ToString());
				b.scoreT.text = PlayerPrefs.GetInt ("RecordScore" + i.ToString()).ToString();
				if(PlayerPrefs.HasKey("RecordTime"+i.ToString()))
				b.dateT.text = PlayerPrefs.GetString ("RecordTime" + i.ToString ());
				int reason=PlayerPrefs.GetInt ("RecordGoReason" + i.ToString());
				if (reason == 1)
					b.reasonT.text = "Dead";
				else
					b.reasonT.text = "Escaped";
			}
		}

	}
	void GetScores(int fromId)
	{
		
			int i;
			if (maxRecords >= fromId) {
				i = fromId;
				name1.text = PlayerPrefs.GetString ("RecordName" + i.ToString ());
				score1.text = PlayerPrefs.GetInt ("RecordScore" + i.ToString ()).ToString ();

				if (PlayerPrefs.HasKey ("RecordTime" + i.ToString ()))
					date1.text = PlayerPrefs.GetString ("RecordTime" + i.ToString ());
				int reason = PlayerPrefs.GetInt ("RecordGoReason" + i.ToString ());
				if (reason == 1)
					reason1.text = "Dead";
				else
					reason1.text = "Escaped";
			}
			if (maxRecords >= fromId+1) {
				i = fromId+1;
				name2.text = PlayerPrefs.GetString ("RecordName" + i.ToString ());
				score2.text = PlayerPrefs.GetInt ("RecordScore" + i.ToString ()).ToString ();

				if (PlayerPrefs.HasKey ("RecordTime" + i.ToString ()))
					date2.text = PlayerPrefs.GetString ("RecordTime" + i.ToString ());
				int reason = PlayerPrefs.GetInt ("RecordGoReason" + i.ToString ());
				if (reason == 1)
					reason2.text = "Dead";
				else
					reason2.text = "Escaped";
			}
			if (maxRecords >= fromId+2) {
				i = fromId+2;
				name3.text = PlayerPrefs.GetString ("RecordName" + i.ToString ());
				score3.text = PlayerPrefs.GetInt ("RecordScore" + i.ToString ()).ToString ();

				if (PlayerPrefs.HasKey ("RecordTime" + i.ToString ()))
					date3.text = PlayerPrefs.GetString ("RecordTime" + i.ToString ());
				int reason = PlayerPrefs.GetInt ("RecordGoReason" + i.ToString ());
				if (reason == 1)
					reason3.text = "Dead";
				else
					reason3.text = "Escaped";
			}
			if (maxRecords >= fromId+3) {
				i = fromId+3;
				name4.text = PlayerPrefs.GetString ("RecordName" + i.ToString ());
				score4.text = PlayerPrefs.GetInt ("RecordScore" + i.ToString ()).ToString ();

				if (PlayerPrefs.HasKey ("RecordTime" + i.ToString ()))
					date4.text = PlayerPrefs.GetString ("RecordTime" + i.ToString ());
				int reason = PlayerPrefs.GetInt ("RecordGoReason" + i.ToString ());
				if (reason == 1)
					reason4.text = "Dead";
				else
					reason4.text = "Escaped";
			}
			if (maxRecords >= fromId+4) {
				i = fromId+4;
				name5.text = PlayerPrefs.GetString ("RecordName" + i.ToString ());
				score5.text = PlayerPrefs.GetInt ("RecordScore" + i.ToString ()).ToString ();

				if (PlayerPrefs.HasKey ("RecordTime" + i.ToString ()))
					date5.text = PlayerPrefs.GetString ("RecordTime" + i.ToString ());
				int reason = PlayerPrefs.GetInt ("RecordGoReason" + i.ToString ());
				if (reason == 1)
					reason5.text = "Dead";
				else
					reason5.text = "Escaped";
			}

	}
	public void Next()
	{
		if (currentIndex + 5 <= maxRecords) {
			currentIndex += 5;
			GetScores (currentIndex);
		}
	}
	public void previous()
	{
		if (currentIndex - 5 >= 1) {
			currentIndex -= 5;
			GetScores (currentIndex);
		}
	}
	public void GoBack()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}
