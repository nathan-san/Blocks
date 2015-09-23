using UnityEngine;
using System.Collections;

public class GeneratingObjects : MonoBehaviour {
	public GameObject invisebleblock;
	public GameObject block;
	public GameObject block2;
	public GameObject block3;
	public GameObject block4;
	public GameObject block5;
	public GameObject block6;
	public GameObject block7;
	public GameObject block8;
	public GameObject block9;
	public GameObject block10;
	public GameObject block11;
	public GameObject block12;
	public GameObject block13;
	public GameObject block14;
	public GameObject block15;
	public GameObject block16;
	public GameObject block17;
	public GameObject block18;
	public GameObject block19;
	public GameObject block20;
	public GameObject block21;


	private GameObject[] blocks;

	public int numberOfObjects = 10;
	public float speed;
	public Vector3 startPosition = new Vector3(0f,0f,0f);
	private Vector3 nextposition;
	private Vector3 blockPosition;
	private int width = 0;
	void Start () {

		blocks = new GameObject[numberOfObjects];
		for(int i = 0; i< numberOfObjects; i++)
		{
			startPosition = new Vector3(-29f,0f,0f);
			GameObject temp = Instantiate(block,startPosition,Quaternion.identity) as GameObject;
			blocks[i] = temp;
		}

		nextposition = startPosition;
		for (int i = 0; i< numberOfObjects; i++) 
		{

			Reposition(i);
		}
	}
	
	// Update is called once per frame
	void Update () {


		for (int i = 0; i< blocks.Length; i++) 
		{
			if (blocks[i] != null)
			{

				blocks[i].transform.Translate(-0.1f *speed,0f,0f);



				if(blocks[i].transform.position.x <=-30 )
				{
					Destroy(blocks[i]);
					if(i ==0)
					{
						blockPosition.x = blocks[blocks.Length -1].transform.position.x +blocks[blocks.Length-1].transform.localScale.x;

					}
					startPosition = blockPosition;

					if (width != 0)
					{
						GameObject temp = Instantiate(invisebleblock,startPosition,Quaternion.identity) as GameObject;

						blocks[i] = temp;


						width --;

					}
					else
					{
						int randomNumber = Random.Range(0,21);
						Debug.Log (randomNumber);
						startPosition = blockPosition;
						if(randomNumber ==2)
						{
							GameObject temp = Instantiate(block2,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width = 14;
						}
						else if (randomNumber ==3)
						{
							GameObject temp = Instantiate(block3,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =17;
						}
						else if (randomNumber ==4)
						{
							GameObject temp = Instantiate(block4,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =4;
						}
						else if (randomNumber ==5)
						{
							GameObject temp = Instantiate(block6,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =10;
						}
						else if (randomNumber ==6)
						{
							GameObject temp = Instantiate(block7,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =26;
						}
						else if (randomNumber ==7)
						{
							GameObject temp = Instantiate(block8,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =26;
						}
						else if (randomNumber ==8)
						{
							GameObject temp = Instantiate(block9,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =4;
						}
						else if (randomNumber ==9)
						{
							GameObject temp = Instantiate(block10,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =26;
						}
						else if (randomNumber ==10)
						{
							GameObject temp = Instantiate(block11,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =21;
						}
						else if (randomNumber ==11)
						{
							GameObject temp = Instantiate(block12,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =9;
						}
						else if (randomNumber ==12)
						{
							GameObject temp = Instantiate(block13,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =23;
						}
						else if (randomNumber ==13)
						{
							GameObject temp = Instantiate(block14,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =26;
						}
						else if (randomNumber ==14)
						{
							GameObject temp = Instantiate(block15,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =9;
						}
						else if (randomNumber ==15)
						{
							GameObject temp = Instantiate(block16,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =14;
						}
						else if (randomNumber ==16)
						{
							GameObject temp = Instantiate(block17,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =14;
						}
						else if (randomNumber ==17)
						{
							GameObject temp = Instantiate(block18,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =7;
						}
						else if (randomNumber ==18)
						{
							GameObject temp = Instantiate(block19,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =21;
						}
						else if (randomNumber ==19)
						{
							GameObject temp = Instantiate(block20,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =6;
						}
						else if (randomNumber ==20)
						{
							GameObject temp = Instantiate(block21,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =25;
						}
						else
						{
							GameObject temp = Instantiate(block5,startPosition,Quaternion.identity) as GameObject;
							blocks[i] = temp;
							width =26;
							break;

						}




					}

				}


			}
		}

	}

	private void Reposition(int index)
	{
		GameObject tempBlock = blocks [index];
		tempBlock.transform.position = nextposition;
		nextposition = new Vector3 (nextposition.x +  tempBlock.transform.localScale.x, 0f, 0f);
	}
}
