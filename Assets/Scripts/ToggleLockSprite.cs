using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLockSprite : MonoBehaviour {

	protected Renderer _renderer;
	// Use this for initialization
	void Awake () {
		_renderer = gameObject.GetComponent<Renderer>();
	}
	
	public void SetLockedState(bool state)
	{
		if (gameObject.name == "lock_closed")
		{
			_renderer.enabled = state;
		} else if (gameObject.name == "lock_open") {
			_renderer.enabled = !state;
		}
	}
	public void Lock()
	{
		if (gameObject.name == "lock_closed")
		{
			_renderer.enabled = true;
		} else if (gameObject.name == "lock_open") {
			_renderer.enabled = false;
		}
	}

	public void Unlock()
	{
		if (gameObject.name == "lock_closed")
		{
			_renderer.enabled = false;
		} else if (gameObject.name == "lock_open")
		{
			_renderer.enabled = true;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
