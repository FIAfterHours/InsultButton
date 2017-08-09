#pragma strict

function Start () {
	
}

function Update () {
	
}

function OnMouseDown() {

	var MainButton = GameObject.Find("MainButton");
	MainButton.SendMessage("switchToSFW");

}