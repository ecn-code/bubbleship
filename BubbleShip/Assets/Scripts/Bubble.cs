using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {

	public int damage = 1;
	public bool isEnemy = false;

	// Use this for initialization
	void Start () {
		Debug.Log ("Antes="+transform.localPosition);
		Debug.Log ("Ahora="+GameController.Instance().moveToCorrectPosition(transform.localPosition));
		transform.localPosition =  GameController.Instance().moveToCorrectPosition(transform.localPosition);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
