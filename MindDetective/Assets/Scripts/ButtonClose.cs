using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClose : MonoBehaviour
{
    [SerializeField]
    private Sprite[] sprites = new Sprite[2];
    [SerializeField]
    private AudioClip clickAudio;

    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    protected void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
        audio.PlayOneShot(clickAudio);

        GenericSpriteController.menuIsOpened = false;

        Destroy(this.transform.parent.gameObject);
    }

    protected void OnMouseEnter()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
        audio.PlayOneShot(clickAudio);
    }

    protected void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
    }
}
