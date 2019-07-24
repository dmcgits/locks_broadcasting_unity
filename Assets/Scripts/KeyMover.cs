using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KeyMover : MonoBehaviour {
	
	protected bool _locked = false;
	protected Renderer _renderer;

	void Start() {
		// Start listening for an event
		// Have some sort of delegate listen to the event type and
		// do as told.
		//MoveButtonClick.OnMoveRequested += MoveRequestedHandler;

		MoveButtonClick.OnMoveDistanceRequested += MoveDistanceRequestedHandler;
		
		_locked = false;
		gameObject.BroadcastMessage("SetLockedState", _locked);
	}
	
	private void OnMouseUpAsButton() {
		// toggle locked
		//if (_locked)
		//{ 
		//	_locked = false;

		//} else {
		//	_locked = true;

		//}
		_locked = !_locked;
		gameObject.BroadcastMessage("SetLockedState", _locked);
	}
	
	private void MoveDistanceRequestedHandler(string direction, float distance)
	{
		
		if (_locked == false)
		{
			switch (direction)
			{
				case "up":
					transform.position += transform.up * distance;
					break;
				case "down":
					transform.position -= transform.up * distance;
					break;
				case "left":
					transform.position -= transform.right * distance; 
					break;
			}
		}
	}


	private void MoveRequestedHandler( String wayToMove )
	{
		//Debug.Log("I heard a request to move " + wayToMove);
		if(_locked == false)
		{
			switch (wayToMove) {
				case "up":
					transform.position += transform.up;
					break;
				case "down":
					transform.position -= transform.up;
					break;
			    case "left":
					transform.position -= transform.right;
					break;
			}
		}
	}
  // Update is called once per frame

  private void MoveDistanceRequestedHandler(String wayToMove, int distToMove)
  {
    Debug.Log("Hey you want me to move " + wayToMove + " about " + distToMove + " units, is that right buddy?");
  }

  private void OnDestroy() {
		MoveButtonClick.OnMoveRequested -= MoveRequestedHandler;
	}
}
