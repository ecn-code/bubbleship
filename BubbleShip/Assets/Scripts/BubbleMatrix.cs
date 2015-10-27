using UnityEngine;
using System.Collections;

public class BubbleMatrix : MonoBehaviour {

	public const int ROW_SIZE = 10;
	public const int COL_SIZE = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Move Bubble to correct position
	void moveToCorrectPosition(){
		//calcColAndRow
		//if row % == 0
		//x = col * COL_SIZE + COL_SIZE - 1
		//else
		//x = col * COL_SIZE + COL_SIZE/2
	}

	//Calculate col and row with x and y position
	void calcColAndRow(Vector3 position){
		int col = position.x / COL_SIZE;
		int row = position.y / ROW_SIZE;
	}

	//insert Bubble into matrix
	void insert(){
		//calcColAndRow y insert into matrix
		//if bubble comes from the user, get neighbours and destroy if its necesary
	}


}
