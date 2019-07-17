using System;
using System.Collections.Generic;
using UnityEngine;

public class MoveButtonClick : MonoBehaviour {
	public static event Action<string> OnMoveRequested = delegate {};
	
	public string wayToMove = "no_event";

	private void OnMouseUpAsButton() {
		Debug.Log("up!");
		// generate an event using the eventToThrow string
		OnMoveRequested(wayToMove);
		
	}
}
