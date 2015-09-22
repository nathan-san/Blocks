using UnityEngine;
using System.Collections;

public class infiniteBG : MonoBehaviour {
	public float speed =1f;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (-0.02f * speed,0f,0f);
		Vector3 temPos = Camera.main.WorldToViewportPoint (this.transform.position);
		if (temPos.x < 0) 
		{

			this.transform.Translate(+30f,0f,0f);

		}
	}
}
