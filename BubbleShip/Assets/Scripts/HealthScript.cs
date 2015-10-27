using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int hp = 3;

	// Method called when there is a collision between a bubble and the spaceship
	void OnTriggerEnter2D (Collider2D collider){

		Debug.Log("collision");

		Bubble bubble = collider.gameObject.GetComponent<Bubble> ();

		hp -= bubble.damage;

		Destroy (bubble.gameObject);

		if (hp == 2) {
			Destroy(GameObject.FindGameObjectWithTag("HP1"));
		}

		if (hp == 1) {
			Destroy(GameObject.FindGameObjectWithTag("HP2"));
		}

		if (hp <= 0) {
			Destroy(GameObject.FindGameObjectWithTag("HP3"));
			Destroy (gameObject);
		}

	}

}
