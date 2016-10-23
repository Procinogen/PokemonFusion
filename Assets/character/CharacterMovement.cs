using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	public float moveSpeed = 6;
	public float jumpHeight = 5;
	public float upDownRange = 100;
	CharacterController controller;
	Vector3 currentMovement;
	float verticalRotation = 0;
	float verticalVelocity = 0;

	void Start () {
		
		controller = GetComponent<CharacterController> ();

	}



	void Update () {


		/*Camera
		float lookRightLeft = Input.GetAxis ("Mouse X") * mouseSpeed * Time.deltaTime;
		transform.Rotate (0, lookRightLeft, 0);

		verticalRotation -= Input.GetAxis ("Mouse Y") * mouseSpeed * Time.deltaTime;
		verticalRotation = Mathf.Clamp (verticalRotation, -upDownRange, upDownRange);
		sight.transform.localRotation = Quaternion.Euler (verticalRotation, 0, 0);*/

		//Movement
		float rightLeft = Input.GetAxis ("Horizontal") * moveSpeed;
		float fwdBack = Input.GetAxis ("Vertical") * moveSpeed;

		currentMovement = new Vector3 (rightLeft, verticalVelocity, fwdBack);
		currentMovement = transform.rotation * currentMovement;

		controller.Move (currentMovement * Time.deltaTime);

		verticalVelocity += Physics.gravity.y * Time.deltaTime;

	}




}