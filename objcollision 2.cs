using UnityEngine;
using System.Collections;
	
public class objcollision : MonoBehaviour {


	[SerializeField]
	private Rigidbody targetRigidbody;
	public GameObject objet; 
	public string obj_oncollide;
	public string obj_destroy;

	healthbar vie = new healthbar(objet, 1);

	void OnCollisionEnter(Collision objet)
	{
		if (objet.gameObject.name == obj_destroy) 
		{
			vie.damages(0.1f);
			//Destroy(targetRigidbody.gameObject);
		}
		/*else
		{
			action();
		}

	}

	void action()
	{
		float moveSpeed = 10f;
		transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);*/

	}
}

