using UnityEngine;
using System.Collections;

public class collision_next_level : MonoBehaviour {

	// Use this for initialization
	/*void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}*/

    void OnCollisionEnter(Collision objet)
    {
        if (objet.gameObject.name == "Cube")
        {
            Destroy(objet.gameObject);
            Application.LoadLevel("niv2");
        }

    }




}
