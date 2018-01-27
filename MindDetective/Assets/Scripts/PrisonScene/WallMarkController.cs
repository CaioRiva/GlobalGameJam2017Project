using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMarkController : GenericSpriteController
{

	void Start () {
        SetGameObjectForSpriteRenderer(this.gameObject);
        SetAudioForSpriteRenderer(GetComponent<AudioSource>() as AudioSource);
    }
	
	void Update () {
		
	}
}
