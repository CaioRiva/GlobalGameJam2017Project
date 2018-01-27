using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDialogController : MonoBehaviour
{
    [SerializeField]
    private Sprite[] sprites = new Sprite[2];
    [SerializeField]
    private AudioClip clickAudio;

    private GameObject originObject;
    private AudioSource audio;

    void Start ()
    {
        audio = GetComponent<AudioSource>();
        GameObject parent = this.transform.parent.gameObject;

        MenuOption menu = (MenuOption)parent.GetComponent(typeof(MenuOption));
        originObject = menu.GetOrigin();
    }

	void Update ()
    {
		
	}

    protected void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
        audio.PlayOneShot(clickAudio);

        GameObject menuOption = GameObject.Find("MenuOption(Clone)");
        Destroy(menuOption);
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
