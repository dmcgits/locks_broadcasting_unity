using System;
using System.Collections.Generic;
using UnityEngine;

public class MoveRequestedEvent  {
	public static event Action<string> onMoveRequested = delegate {};
	
}
