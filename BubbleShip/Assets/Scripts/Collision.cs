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
	
	
	// Method called when there is a collision between a bubble and the spaceship
	void OnTriggerEnter2D (Collider2D collider){
		
		if (collider.name == "Wall") {

			Debug.Log (collider.name);


		} else {

			Debug.Log (collider.name);
			
			Bubble bubble = collider.gameObject.GetComponent<Bubble> ();
			
			
			if (bubble.playerFired) {
				return;
			}
			
			Debug.Log ("collision");
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
		}
	} 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
