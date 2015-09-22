using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text ScoreText;
	private int score;
	// Use this for initialization
	void Start () {
		score = 0;
		SetScoreText();
	}
	
	// Update is called once per frame
	void Update () {




	}
	void SetScoreText() {
		score = score + 1;
		StartCoroutine(MyMethod());
		ScoreText.text = "Score: " + score.ToString();
		
		
	}
	IEnumerator MyMethod() {
		yield return new WaitForSeconds(0.3f);
		SetScoreText();
	}

}
