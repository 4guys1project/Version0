using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
	public GameObject objet;
	public int life;
	public float damage;

	public healthbar( GameObject objet, int life)
	{
		this.objet = objet;
		this.life = life;

	}

	public void damages (float damage)
	{
		objet.GetComponent<Scrollbar> ().size = life - damage;
	}

}
