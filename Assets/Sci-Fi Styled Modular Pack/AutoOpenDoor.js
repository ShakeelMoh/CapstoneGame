#pragma strict

private var anim : Animator;
var character : GameObject;
var character2 : GameObject;
var distanceToOpen:float = 10;

private var characterNearbyHash : int = Animator.StringToHash("character_nearby");

function Start () 
{
    anim = GetComponent("Animator");
}


function Update (){

	var distance = Vector3.Distance(transform.position,character.transform.position);
	var distance2 = Vector3.Distance(transform.position, character2.transform.position);
	if (distanceToOpen>=distance || distanceToOpen >= distance2){
    	anim.SetBool(characterNearbyHash, true);
    }else{
    	anim.SetBool(characterNearbyHash, false);
    }

}