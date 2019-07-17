using System;
using System.Collections.Generic;
using UnityEngine;

public class MoveButtonClick : MonoBehaviour {
	public static event Action<string> OnMoveRequested = delegate {};

  public static event Action<string, int> OnMoveDistanceRequested = delegate { };

  public string wayToMove = "no_event";
  public int distanceToMove = 1;

  private void OnMouseUpAsButton() {
		// generate an event using the eventToThrow string
		OnMoveRequested(wayToMove);

    OnMoveDistanceRequested(wayToMove, distanceToMove);
  }
}
