using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSpriteController : MonoBehaviour
{
    public static bool menuIsOpened;

    [SerializeField]
    private Sprite[] sprites = new Sprite[2];
    [SerializeField]
    private AudioClip clickAudio;
    [SerializeField]
    private GameObject optionMenu;
    [SerializeField]
    private GameObject notebook;

    private AudioSource audio;
    private GameObject baseGameObject;
    private bool isPerson;

    protected void OnMouseDown()
    {
        if(!menuIsOpened)
        {

            if(isPerson)
            {
                GameObject tempMenu = Instantiate(optionMenu) as GameObject;
                tempMenu.transform.position = new Vector3(baseGameObject.transform.position.x,
                    baseGameObject.transform.position.y, tempMenu.transform.position.z);

            
                MenuOption menu = (MenuOption)tempMenu.GetComponent(typeof(MenuOption));
                menu.SetOrigin(baseGameObject);

                gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
                menuIsOpened = true;
            }
            else
            {
                GameObject tempNotebook = Instantiate(notebook) as GameObject;
                tempNotebook.transform.position = new Vector3(Camera.main.gameObject.transform.position.x, 
                    Camera.main.gameObject.transform.position.y, tempNotebook.transform.position.z);

                menuIsOpened = true;
            }
        }
    }

    protected void OnMouseEnter()
    {
        if(!menuIsOpened)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
            audio.PlayOneShot(clickAudio);
        }
        
    }

    protected void OnMouseExit()
    {
        if (!menuIsOpened)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
        }
    }

    protected void SetGameObjectForSpriteRenderer(GameObject gameObject)
    {
        baseGameObject = gameObject;

    }

    protected void SetAudioForSpriteRenderer(AudioSource audio)
    {
        this.audio = audio;
    }

    protected void SetIsPerson(bool isPerson)
    {
        this.isPerson = isPerson;
    }

    protected bool IsPerson(bool isPerson)
    {
        return isPerson;
    }
}
