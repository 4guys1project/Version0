#pragma strict

var cubeSound : AudioClip;

var couleurs : Transform;

function OnTriggerEnter(objetInfo : Collider)
{
	if(objetInfo.gameObject.name == "cube")
	{
		audio.PlayOneShot(cubeSound);
		Instantiate(couleurs, transform.position,transform.rotation);
		Destroy(objetInfo.gameObject);
	}
}
