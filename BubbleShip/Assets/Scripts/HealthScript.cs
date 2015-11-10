using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int hp = 3;
	GameController gameController;

	void Awake ()
	{

		gameController = GameController.Instance ();
	}


	// Method called when there is a collision between a bubble and the spaceship
	void OnTriggerEnter2D (Collider2D collider){




		Bubble bubble = collider.gameObject.GetComponent<Bubble> ();

		if (bubble.playerFired)
			return;

		Debug.Log("collision");
		Debug.Log("Bubble Damage: "+ bubble.damage);

		hp -= bubble.damage;

		Debug.Log("Lifes left: "+ hp);

		//Destroy (bubble.gameObject);
		gameController.destroy (bubble.gameObject);

		if (hp == 2) {
			Debug.Log("hp==2");

			Destroy(GameObject.FindGameObjectWithTag("HP1"));
		}

		if (hp == 1) {
			Debug.Log("hp==1");

			Destroy(GameObject.FindGameObjectWithTag("HP2"));
		}

		if (hp <= 0) {
			Debug.Log("hp==0");

			Destroy(GameObject.FindGameObjectWithTag("HP3"));
			Destroy (gameObject);
		}

	}

}
