using UnityEngine;
using System.Collections;

public class BubbleMatrix
{

	public const int ROW_SIZE = 10;
	public const int COL_SIZE = 10;

	//Move Bubble to correct position
	Vector2 moveToCorrectPosition (Vector2 position)
	{
		Vector2 rowCol = calcColAndRow (position);
		int x, y;
		if (rowCol.y % 2 == 0) {
			x = (int)rowCol.x * COL_SIZE + COL_SIZE - 1;
		} else {
			x = (int)rowCol.x * COL_SIZE + COL_SIZE / 2;
		}
		y = (int) rowCol.y * ROW_SIZE + ROW_SIZE / 2;
		return new Vector2 (x, y);
	}

	//Calculate col and row with x and y position
	Vector2 calcColAndRow (Vector2 position)
	{
		int col = (int)position.x / COL_SIZE;
		int row = (int)position.y / ROW_SIZE;

		return new Vector2 (col, row);
	}

	//insert Bubble into matrix
	void insert ()
	{
		//calcColAndRow y insert into matrix
		//if bubble comes from the user, get neighbours and destroy if its necesary
	}


}
