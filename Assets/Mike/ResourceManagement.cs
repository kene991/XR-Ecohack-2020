using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResourceManagement : MonoBehaviour
{

    public TMP_Text resourcesText;
    public int resourcesAvaliableInt = 1000;

    // Update is called once per frame
    void Update()
    {
        resourcesText.text = "Resources: " + resourcesAvaliableInt;
    }
}
