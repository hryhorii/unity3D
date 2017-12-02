using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour {

	// Use this for initialization
	public Transform coin;

	void Start () {
		StartCoroutine(SpawnCoin());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnCoin()
	{

		while (true)
		{
			if (GlobalClass.Instance.coins < 10) {
				int x, y;
				x = Random.Range (-400, 400);
				y = Random.Range (-300, 300);
				Instantiate (coin, new Vector3 (x / 100, y / 100, 0), Quaternion.identity);
				GlobalClass.Instance.coins++;
			}
			yield return new WaitForSeconds(5.0f);
		}
		yield break;
	}
}
