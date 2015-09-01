using UnityEngine;
using System.Collections;

[RequireComponent (typeof (CharacterController))]
public class CharcterControls : MonoBehaviour {

	public float speed;
	public float gravity;

	private CharacterController controller;

	void Start () {
		controller = gameObject.GetComponent<CharacterController>();
	}

	void Update () {
		Vector3 vertMove = new Vector3 (0f, 0f,  Input.GetAxis ("Vertical") * speed);
		Vector3 horMove = new Vector3 (Input.GetAxis ("Horizontal") * speed, 0f, 0f);
		Vector3 movement = vertMove + horMove;
		movement.y = movement.y + gravity;

		controller.Move (Vector3.MoveTowards(movement, movement, 10f));
	}
}
