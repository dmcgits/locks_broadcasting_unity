using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLockSprite : MonoBehaviour {

	protected Renderer _renderer;
	// Use this for initialization
	void Awake () {
		_renderer = gameObject.GetComponent<Renderer>();
		SpriteRenderer _spriteRender = gameObject.GetComponent<SpriteRenderer>();
		_spriteRender.color = new Color(0.1f, 1.0f, 0.5f);
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
	
	// Update is called once per frame
	void Update () {
		
	}
}
