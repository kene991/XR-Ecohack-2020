using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionDescription : MonoBehaviour
{
    public string description;
    public GameObject option;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        option.SetActive(true);
        TextHolder.textDescription = description;
    }
    public void optionOne()
    {
        
    }
    public void optionTwo()
    {

    }
}
