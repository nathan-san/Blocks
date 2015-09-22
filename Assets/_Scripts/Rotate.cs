using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	Color color;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (1f,0f,1f);
		float r = Random.value;
		float g = Random.value;
		float b = Random.value;
		color = new Color (r, g, b);
		//gameObject.GetComponent<Renderer>().material.color = colors[Random.Range(0, 1)];
		gameObject.GetComponent<Renderer> ().material.color = color;
	}
}
