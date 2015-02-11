#pragma strict

var rotationSpeed : float = 2.0;

function Start () {

}

function Update () {
transform.Rotate(Vector3(0,rotationSpeed,0));

}