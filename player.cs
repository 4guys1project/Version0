using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
    public float playerSpeed1 = 10f;
    public float playerSpeed2 = 5.0f;

    public float speed = 18.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 10.0F;

    void controller ()
    {
        Vector3 moveDirection = Vector3.zero;

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)

        {
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;
                if (Input.GetButton("Jump"))
                {
                    moveDirection.y = jumpSpeed;
                }
        }
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);

    }

	// Use this for initialization
	void Start () {

        transform.position = new Vector3(20, 3, 20);

	}
	
    
	// Update is called once per frame
	void Update () {
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }*/
	controller();
	}
}
