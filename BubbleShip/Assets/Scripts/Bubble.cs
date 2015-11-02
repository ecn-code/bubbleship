using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {

	public int damage = 1;
	public bool isEnemy = false;

	// Use this for initialization
	void Start () {
		Debug.Log ("Antes="+transform.position);
		Debug.Log ("Ahora="+GameController.Instance().moveToCorrectPosition(transform.position));
		transform.Translate (GameController.Instance().moveToCorrectPosition(transform.position));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
