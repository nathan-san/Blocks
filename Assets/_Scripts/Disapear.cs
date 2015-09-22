using UnityEngine;
using System.Collections;

public class Disapear : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x <= 0) 
		{
			Destroy (this.gameObject);
		}
	}
}
