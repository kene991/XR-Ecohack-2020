using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class OptionDescription : MonoBehaviour
{
    public string description;
    
    public GameObject option;
    public Button buttonOne;
    public string buttonOneDescription;
    public Button buttonTwo;
    public string buttonTwoDescription;
    bool selected = false;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    private void OnMouseDown()
    {
        selected = true;
        option.SetActive(true);
        TextHolder.textDescription = description;
        buttonOne.onClick.AddListener(optionOne);
        buttonTwo.onClick.AddListener(optionTwo);
        buttonOne.GetComponentInChildren<TextMeshProUGUI>().SetText(buttonOneDescription);
        buttonTwo.GetComponentInChildren<TextMeshProUGUI>().SetText(buttonTwoDescription);

    }
    public void OnClick()
    {
        selected = true;
        option.SetActive(true);
        TextHolder.textDescription = description;
        buttonOne.onClick.AddListener(optionOne);
        buttonTwo.onClick.AddListener(optionTwo);
        buttonOne.GetComponentInChildren<TextMeshProUGUI>().SetText(buttonOneDescription);
        buttonTwo.GetComponentInChildren<TextMeshProUGUI>().SetText(buttonTwoDescription);

    }
    public void optionOne()
    {
        Debug.Log("1");
        selected = false;
        option.SetActive(false);
    }
    public void optionTwo()
    {
        Debug.Log("2");
        selected = false;
        option.SetActive(false);
    }
}
