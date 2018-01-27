using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceOfficerController : GenericSpriteController
{

    protected void Start()
    {
        SetGameObjectForSpriteRenderer(this.gameObject);
        SetAudioForSpriteRenderer(GetComponent<AudioSource>() as AudioSource);
    }
	
	protected void Update()
    {
     
    }
}
