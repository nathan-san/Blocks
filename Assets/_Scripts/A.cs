using UnityEngine;
using System.Collections;

public class A : MonoBehaviour {
	//public WWW(string url,WWWForm form);
	// Use this for initialization
	public string name = "name";
	public int score = 0;
	void Start () {
		string url = "http://localhost/bap/pro/2deles/result.php";
		WWWForm form = new WWWForm();
		
		form.AddField("var1",name);
		form.AddField("var2",score);
		WWW www = new WWW (url, form);
		StartCoroutine(WaitForRequest(www));

	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		if (www.error == null) 
		{
			Debug.Log ("je hebt internet!" + www.text);
		} 
		else 
		{
			Debug.Log ("je hebt GEEN internet!"+ www.error);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
