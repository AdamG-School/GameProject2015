using UnityEngine;
using System.Collections;

public class CharcterControls : MonoBehaviour {

	public float speed;

	private CharacterController controller;
	private Rigidbody characterRB;

	void Start () {
		characterRB = gameObject.GetComponent<Rigidbody> ();
	}

	void Move (Vector3 direction) {
		characterRB.AddForce (direction);
	}

	void Update () {
		Vector3 vertMove = new Vector3 (0f, 0f,  Input.GetAxis ("Vertical") * speed);
		Vector3 horMove = new Vector3 (Input.GetAxis ("Horizontal") * speed, 0f, 0f);
		Vector3 movement = vertMove + horMove;

		Debug.Log (movement);
		Move(movement);
	}
}
