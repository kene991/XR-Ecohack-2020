using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchGameObject : MonoBehaviour
{
    //basics of touching game object on smartphone from https://stackoverflow.com/questions/38565746/tap-detection-on-a-gameobject-in-unity

    public GameObject Event1Panel;

    public void OnMouseDown()
    {
        Event1Panel.SetActive(true);
        gameObject.SetActive(false);
    }
}
