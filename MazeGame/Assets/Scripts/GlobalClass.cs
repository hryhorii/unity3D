using UnityEngine;
using System.Collections;


public class GlobalClass : MonoBehaviour {
	public static GlobalClass Instance;
	public int coins;
	public int score;
	public int gameOverReason;
	public bool isGameOver;
	public string playerName;

	// Use this for initialization
	void Start () {
		coins = 0;
		score = 0;
		gameOverReason = 1;
		isGameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Awake ()
	{
		
		if (Instance == null)
		{
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
		else if (Instance != this)
		{
			Destroy (gameObject);
		}




	}



}
