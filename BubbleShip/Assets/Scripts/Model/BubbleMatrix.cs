﻿using UnityEngine;
using System.Collections;

public class BubbleMatrix
{

	public const int ROW_SIZE = 1;
	public const int COL_SIZE = 1;

	//Move Bubble to correct position
	public Vector3 moveToCorrectPosition (Vector3 position)
	{
		Vector3 rowCol = calcColAndRow (position);
		float x, y;
		//Debug.Log (rowCol.y % 2);
		if (rowCol.y % 2 == 0) {
			x = rowCol.x * COL_SIZE + COL_SIZE / 2f;
		} else {
			x = rowCol.x * COL_SIZE + COL_SIZE / 2f;
		}
		y = rowCol.y * ROW_SIZE + ROW_SIZE / 2f;
		return new Vector3 (x, y, position.z);
	}

	//Calculate col and row with x and y position
	Vector3 calcColAndRow (Vector3 position)
	{
		int col = (int)position.x / COL_SIZE;
		int row = (int)position.y / ROW_SIZE;

		return new Vector3 (col, row, position.z);
	}

	//insert Bubble into matrix
	void insert ()
	{
		//calcColAndRow y insert into matrix
		//if bubble comes from the user, get neighbours and destroy if its necesary
	}


}
