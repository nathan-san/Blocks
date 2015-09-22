using UnityEngine;
using System.Collections;

public class Highscores : MonoBehaviour {

	//All you need to connect it to dreamlo
	const string privateCode = "6GVHkiNgU02q8Oz6hjt3JQrxHRFXuuhUqOOqrJF4oZlg";
	const string publicCode = "55e4bbf26e51b615c875c77a";
	const string webURL = "http://dreamlo.com/lb/";

	//Array
	public Highscore[] highscoreList;

	void Awake()
	{
		AddNewHighscore ("Tim", 90);
		AddNewHighscore ("Joey", 40);
		AddNewHighscore ("Nathan", 50);

		DownloadHighscores ();
	}

	public void AddNewHighscore(string username, int score)
	{
		StartCoroutine (UploadNewHighscore (username, score));
	}

	IEnumerator UploadNewHighscore(string username, int score)
	{
		WWW www = new WWW (webURL + privateCode + "/add/" + WWW.EscapeURL (username) + "/" + score);
		yield return www;

		if (string.IsNullOrEmpty (www.error))
			print ("Upload Succesful");
		else 
		{
			print ("Error Uploading " + www.error);
		}
	}

	public void DownloadHighscores ()
	{
		StartCoroutine ("DownloadScore");
	}

	IEnumerator DownloadScore()
	{
		WWW www = new WWW (webURL + publicCode + "/pipe/");
		yield return www;
		
		if (string.IsNullOrEmpty (www.error))
			FormatHighscores (www.text);
		else 
		{
			print ("Error Uploading " + www.error);
		}
	}

	void FormatHighscores(string textStream)
	{
		string[] entries = textStream.Split (new char[] {'\n'}, System.StringSplitOptions.RemoveEmptyEntries);
		highscoreList = new Highscore[entries.Length];

		for (int i = 0; i<entries.Length; i++) 
		{
			string[] entryInfo = entries[i].Split(new char[] {'|'});
			string username = entryInfo[0];
			int score = int.Parse(entryInfo[1]);
			highscoreList[i] = new Highscore(username,score);
		}
	}
}

public struct Highscore {
	public string username;
	public int score;

	public Highscore(string _username, int _score){
		username = _username;
		score = _score;
	}
}

