using UnityEngine;
using System.Collections;

public class GeneratingObjects : MonoBehaviour {
	public GameObject invisebleblock;
	public GameObject block;
    [SerializeField]
    private GameObject[] chunks;
	private GameObject[] currentBlocks;

	public int numberOfObjects = 10;
	public float speed;
	public Vector3 startPosition = new Vector3(0f,0f,0f);
	private Vector3 nextposition;
	private Vector3 blockPosition;
	private int width = 0;
	void Start () {

		currentBlocks = new GameObject[numberOfObjects];
		for(int i = 0; i< numberOfObjects; i++)
		{
			startPosition = new Vector3(-29f,0f,0f);
			GameObject temp = Instantiate(block,startPosition,Quaternion.identity) as GameObject;
			currentBlocks[i] = temp;
		}

		nextposition = startPosition;
		for (int i = 0; i< numberOfObjects; i++) 
		{

			Reposition(i);
		}
	}
	void Update () {
		for (int i = 0; i< currentBlocks.Length; i++) 
		{
			if (currentBlocks[i] != null)
			{

				currentBlocks[i].transform.Translate(-0.1f *speed,0f,0f);
				if(currentBlocks[i].transform.position.x <=-30 )
				{
					Destroy(currentBlocks[i]);
					if(i ==0)
					{
						blockPosition.x = currentBlocks[currentBlocks.Length -1].transform.position.x +currentBlocks[currentBlocks.Length-1].transform.localScale.x;
					}
					startPosition = blockPosition;

					if (width != 0)
					{
						GameObject temp = Instantiate(invisebleblock,startPosition,Quaternion.identity) as GameObject;
						currentBlocks[i] = temp;
						width --;
					}
					else
					{
						int randomNumber = Random.Range(0,21);
                        startPosition = blockPosition;
                        GameObject temp = Instantiate(chunks[randomNumber], startPosition, Quaternion.identity) as GameObject;
                        currentBlocks[i] = temp;
                        width = temp.GetComponent<ChunkWidth>().Width;
					}
				}
			}
		}
	}
	private void Reposition(int index)
	{
		GameObject tempBlock = currentBlocks [index];
		tempBlock.transform.position = nextposition;
		nextposition = new Vector3 (nextposition.x +  tempBlock.transform.localScale.x, 0f, 0f);
	}
}
