#pragma strict

var vitesseMouvement = 4.0;
var vitesseRotation = 3.0;

function Start () {

}

function Update () {
	var controller : CharacterController = GetComponent(CharacterController);
	transform.Rotate(0,Input.GetAxis("Horizontal")* vitesseRotation,0);
	
	var enAvant = transform.TransformDirection(Vector3.forward);
	var vitesseDeplacement = vitesseMouvement * Input.GetAxis("Vertical");
	
	controller.SimpleMove(enAvant * vitesseDeplacement);
	
	}

@script RequireComponent (CharacterController)