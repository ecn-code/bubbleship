using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {

	public int damage = 1;
	public bool isEnemy = false;
	public bool playerFired = false;
	public Vector3 speed, direction;
	GameController gameController;

	void Awake(){
		if (!playerFired) {
			speed = new Vector3 (0, 0, 0);
		}
		direction = new Vector3 (1,1,0);
		gameController = GameController.Instance ();
	}

	// Use this for initialization
	void Start () {
		//Debug.Log ("Antes="+transform.localPosition);
		//Debug.Log ("Ahora="+GameController.Instance().moveToCorrectPosition(transform.localPosition));

		//Debug.Log ("PlayerFired: "+playerFired);
		if(!playerFired)
			transform.localPosition =  gameController.moveToCorrectPosition(transform.localPosition,false);
		//else Debug.Log ("Speed:"+speed);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = new Vector3(speed.x * direction.x, speed.y * direction.y, 0);
		movement *= Time.deltaTime;
		
		transform.Translate (movement);
	}

	void OnTriggerEnter2D (Collider2D collider){
		Bubble scriptBubble = collider.gameObject.GetComponent<Bubble>();
		if (scriptBubble != null && scriptBubble.playerFired) {
			scriptBubble.speed = new Vector3(0, 0, 0);
			//Debug.Log(scriptBubble.playerFired);
			collider.gameObject.transform.localPosition
				=  gameController.moveToCorrectPosition
					(collider.gameObject.transform.localPosition,true);
			//Comprobar si hay que explotar
			scriptBubble.playerFired = false;
		}
	}
}
