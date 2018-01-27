using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageController : GenericSpriteController
{
    protected void Start()
    {
        SetGameObjectForSpriteRenderer(this.gameObject);
        SetAudioForSpriteRenderer(GetComponent<AudioSource>() as AudioSource);
        SetIsPerson(false);
    }

    protected void Update()
    {

    }
}
