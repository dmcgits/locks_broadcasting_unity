using System;
using System.Collections.Generic;
using UnityEngine;

public class MoveButtonClick : MonoBehaviour
{

	public static event Action<string> OnMoveRequested = delegate { };

	public static event Action<string, float> OnMoveDistanceRequested = delegate { };
	
	public string wayToMove = "no_event";

	private void OnMouseUpAsButton()
	{
		// generate an event using the eventToThrow string
		//OnMoveRequested(wayToMove);

		OnMoveDistanceRequested(wayToMove, 0.5f);
	}

}