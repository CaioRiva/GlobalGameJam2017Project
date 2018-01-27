using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOption : MonoBehaviour {

    private GameObject originObject;

    void Start()
    {

    }
	
	void Update () {
		
	}

    public void SetOrigin(GameObject origin)
    {
        originObject = origin;
    }

    public GameObject GetOrigin()
    {
        return originObject;
    }
}
