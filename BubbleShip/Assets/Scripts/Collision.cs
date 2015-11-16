using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Collision : MonoBehaviour {
	
	public int hp = 3;
	GameController gameController;
	public Sprite hpRemoved;
	
	void Awake ()
	{
		
		gameController = GameController.Instance ();

	}
	
	
	// Methods called when there is a collision between a walls and the spaceship
	void OnCollisionEnter2D (Collision2D col){
		Debug.Log ("Estoy en OnCollisionEnter2D" + col.gameObject.name);
		handleCollision (col);
	}
	
	void OnCollisionStay2D(Collision2D col){
		Debug.Log ("Estoy en OnCollisionStay2D" + col.gameObject.name);
		handleCollision (col);
	}
	
	void handleCollision(Collision2D col){
		
		Debug.Log ("Estoy en handleCollision: " + col.gameObject.name);

		if (col.gameObject.tag == "RightWall" || col.gameObject.tag == "LeftWall") {

			Debug.Log ("Pared collision--------------------------");

			return;
		} // end if for collision with wall detection
	}

	// Methods called when there is a collision between the bubbles and the spaceship
	void OnTriggerEnter2D(Collider2D col){

		Debug.Log ("Estoy en OnTriggerEnter2D: " + col.gameObject.name);

		Bubble bubble = col.gameObject.GetComponent<Bubble>();

		if (bubble.playerFired) {
			return;
		}

		if (col.gameObject.tag == "NormalBubble") {

			//Debug.Log ("collision");
			Debug.Log ("Bubble Damage: " + bubble.damage);
			
			hp -= bubble.damage;
			
			Debug.Log ("Lifes left: " + hp);
			
			//Destroy (bubble.gameObject);
			gameController.destroy (bubble.gameObject);
			
			if (hp == 2) {
				Debug.Log ("hp==2");
				GameObject.FindGameObjectWithTag ("HP1").GetComponent<Image> ().sprite = hpRemoved;
				//Destroy(GameObject.FindGameObjectWithTag("HP1"));
			}
			
			if (hp == 1) {
				Debug.Log ("hp==1");
				GameObject.FindGameObjectWithTag ("HP2").GetComponent<Image> ().sprite = hpRemoved;
				//Destroy(GameObject.FindGameObjectWithTag("HP2"));
			}
			
			if (hp <= 0) {
				Debug.Log ("hp==0");
				GameObject.FindGameObjectWithTag ("HP3").GetComponent<Image> ().sprite = hpRemoved;
				//Destroy(GameObject.FindGameObjectWithTag("HP3"));
				Destroy (gameObject);
			}

		} //end if for collision spaceship-bubble detection

	}// end OnTriggerEnter2D

}
