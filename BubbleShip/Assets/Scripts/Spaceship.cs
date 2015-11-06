using UnityEngine;
using System.Collections;
using System;

public class Spaceship : MonoBehaviour {

	//velocidad
	public Vector2 speed = new Vector2(0.8f, 0.5f);

	public GameObject bubble;
	public float timeLapsedLastFire = 0;

	//public bu bubble;

	
	// Update is called once per frame
	void Update () {


		float inputX = Input.GetAxis ("Horizontal");
		//float inputY = Input.GetAxis ("Vertical");

		Vector3 tmp = new Vector3 (speed.x * inputX, speed.y , 0);

		Vector3 movement = tmp * Time.deltaTime;
		transform.Translate (movement);

		movement.x = 0;
		Camera.main.transform.Translate(movement);

		timeLapsedLastFire += Time.deltaTime;
		bool fire = Input.GetButton ("Fire1");
		if (fire && timeLapsedLastFire>0.5) {
			timeLapsedLastFire = 0;
			Bubble bScript = bubble.GetComponent<Bubble> ();
			bScript.playerFired = true;
			Instantiate (bubble, transform.position, transform.rotation);

			Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Debug.Log("World:"+worldMousePosition+"Mouse:"+Input.mousePosition);
			//transform.LookAt(worldMousePosition);
			//Vector3 direction = worldMousePosition - transform.position;
			//float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Atan2;
			//bScript.speed = direction / 10f;
		}

	}
}
