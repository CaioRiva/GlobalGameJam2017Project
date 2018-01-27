using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSpriteController : MonoBehaviour
{
    [SerializeField]
    private Sprite[] sprites = new Sprite[2];
    [SerializeField]
    private AudioClip clickAudio;

    private AudioSource audio;
    private GameObject baseGameObject;

    protected void OnMouseEnter()
    {
        Debug.Log("Entrou");
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
        audio.PlayOneShot(clickAudio);
    }

    protected void OnMouseExit()
    {
        Debug.Log("Saiu");
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
    }

    protected void SetGameObjectForSpriteRenderer(GameObject gameObject)
    {
        baseGameObject = gameObject;
             
    }

    protected void SetAudioForSpriteRenderer(AudioSource audio)
    {
        this.audio = audio;
    }
}
