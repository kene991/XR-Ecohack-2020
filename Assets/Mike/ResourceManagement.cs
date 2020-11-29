using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResourceManagement : MonoBehaviour
{

    public Text resourcesText;
    public int resourcesAvaliableInt = 1000;

    // Update is called once per frame
    void Update()
    {
        resourcesText.text = "Resources: " + resourcesAvaliableInt;
    }

    public void onSavePressed()
    {
        resourcesAvaliableInt = resourcesAvaliableInt - 100;
        //set event clicked on = false
    }

    public void onDoNotSavePressed()
    {
        //set event clicked on = false
    }
}
