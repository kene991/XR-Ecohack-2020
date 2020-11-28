using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextHolder : MonoBehaviour
{
    TextMeshProUGUI text;
    public static string textDescription;
    // Start is called before the first frame update
    void Start()
    {
        
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText(textDescription);
    }
}
