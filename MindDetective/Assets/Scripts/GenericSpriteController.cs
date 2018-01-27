using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSpriteController : MonoBehaviour
{
    [SerializeField]
    private Sprite[] sprites = new Sprite[2];
    private GameObject gameObject;

    protected void OnMouseEnter()
    {
        Debug.Log("Entrou");
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
    }

    protected void OnMouseExit()
    {
        Debug.Log("Saiu");
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
    }

    protected void SetGameObjectForSpriteRenderer(GameObject gameObject)
    {
        this.gameObject = gameObject;
             
    }
}
