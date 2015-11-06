using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {

	public int damage = 1;
	public bool isEnemy = false;
	public bool playerFired = false;
	public Vector3 speed, direction;

	void Awake(){
		if (!playerFired) {
			speed = new Vector3 (0, 0, 0);
		}
		direction = new Vector3 (1,1,0);
	}

	// Use this for initialization
	void Start () {
		//Debug.Log ("Antes="+transform.localPosition);
		//Debug.Log ("Ahora="+GameController.Instance().moveToCorrectPosition(transform.localPosition));

		Debug.Log ("PlayerFired: "+playerFired);
		if(!playerFired)
			transform.localPosition =  GameController.Instance().moveToCorrectPosition(transform.localPosition);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = new Vector3(speed.x * direction.x, speed.y * direction.y, 0);
		movement *= Time.deltaTime;
		
		transform.Translate (movement);
	}
}
