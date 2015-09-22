using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {


	Color color;
	void Start()
	{

		change ();
	}
	public void change()
	{
		float r = Random.value;
		float g = Random.value;
		float b = Random.value;
		color = new Color (r, g, b);
		//gameObject.GetComponent<Renderer>().material.color = colors[Random.Range(0, 1)];
		gameObject.GetComponent<Renderer> ().material.color = color;
	}



}
