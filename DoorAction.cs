using UnityEngine;
using System.Collections;

public class DoorAction : MonoBehaviour {

	// Use this for initialization
	//[SerializeField]

	public GameObject target;
	public GameObject objetp; 
	//public string target;
	//public string obj_destroy;
	

	void OnCollisionEnter(Collision objet)
	{
		if (objet.gameObject == target)
		{
			/*Vector3 relativePos = objetp.position - transform.position;
			Quaternion rotation = Quaternion.LookRotation(relativePos);
			transform.rotation = rotation;*/

			public Quaternion rotation = Qua


		}
	}
}
