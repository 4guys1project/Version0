using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class controller : MonoBehaviour {
	public float MoveSpeed;
	public float RotationSpeed;
	void Start()
	{
			
	}
	//private bool isFalling = false;

	//public float speed = 6.0F;
	public float jumpSpeed;
	//public float gravity = 20.0F;
	//private Vector3 moveDirection = Vector3.zero;
	void Update() {
		CharacterController controller = GetComponent<CharacterController> ();
		//if (controller.isGrounded) {
						Vector3 foward = Input.GetAxis ("Vertical") * transform.TransformDirection (Vector3.forward) * MoveSpeed;
						transform.Rotate (new Vector3 (0, Input.GetAxis ("Horizontal") * RotationSpeed * Time.deltaTime, 0));
						controller.SimpleMove (Physics.gravity);
						controller.Move (foward * Time.deltaTime);

						/*moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;*/
				if (Input.GetKey (KeyCode.Space))
				{
					transform.Translate (Vector3.up * jumpSpeed* Time.deltaTime);
					//controller.SimpleMove (Physics.gravity);
			
				}
		//}
	}
	
}