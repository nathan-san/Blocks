using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public GameObject ColorObject;
	public GameObject Manager;
	public GameObject GameOver;
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	public float jumpCount = 0.0f; 
	public bool isGrounded = true;
	private Vector3 moveDirection = Vector3.zero;
	public AudioSource jumpSound;
    public Text scoreText;
    private int score = 0;
    private CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void FixedUpdate() {
        score++;
        scoreText.text = "Score: " + score;

		if (controller.isGrounded) {
			moveDirection = new Vector3 (0, 0, 0);
			moveDirection = transform.TransformDirection (moveDirection);
			moveDirection *= speed;

			this.transform.rotation = Quaternion.identity;
			//this.transform.Rotate.x = 0;
			if (Input.GetButton ("Jump"))
			{
				jumpSound.Play();
				ColorObject.GetComponent<ColorChange>().change();
				moveDirection.y = jumpSpeed;
			}
		} 
		else 
		{
			this.transform.Rotate (0f,0f,-2.2f);
		}
		
		if (jumpCount < 1) {
			if (Input.GetButtonDown ("Jump")) { 
				jumpSound.Play();
				ColorObject.GetComponent<ColorChange>().change();
				moveDirection.y = jumpSpeed; 
				jumpCount++;
			} 
		} 

		if (jumpCount == 2 && controller.isGrounded) {
			jumpCount--;
		}
		
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {


		if(other.gameObject.tag =="doublejump" )
		//if (other.gameObject.tag =="doublejump") 
		{
			Destroy(other.gameObject);
			jumpCount =0;

		}
	
		if(other.gameObject.tag =="danger" ||other.gameObject.tag =="Floor" )
		{

			Instantiate(GameOver);
			Destroy(this.gameObject);

			Destroy(Manager);
		}


	}

	
	
}
