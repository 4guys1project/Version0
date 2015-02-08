using UnityEngine;
using System.Collections;

public class IA : MonoBehaviour {

	public Transform target;
	NavMeshAgent agent;

	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}

	// Use this for initialization
	
	// Update is called once per frame
	void Update ()
	{
		agent.SetDestination(target.position);
	}
}
