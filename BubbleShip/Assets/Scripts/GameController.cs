using UnityEngine;
using System.Collections;

public class GameController{

	public static GameController _instance = null;

	BubbleMatrix bubbleMatrix;

	public Vector3 moveToCorrectPosition(Vector3 pos, bool substract){
		return bubbleMatrix.moveToCorrectPosition (pos, substract);
	}

	public static GameController Instance() { 
		
		if (_instance==null)
		{
			_instance=new GameController() ;
			
		}
		return _instance;
	}

	public GameController() {
		Debug.Log("Starts GameController ");
		bubbleMatrix = new BubbleMatrix ();
	}
}
