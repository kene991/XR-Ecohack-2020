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
    public bool firstSelection =  false;
    
    public Button buttonTwo;
    public string buttonTwoDescription;
    public bool secondSelection = false;
    bool good = false;

    
    
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
        
        option.SetActive(true);
        TextHolder.textDescription = description;
        buttonOne.onClick.AddListener(optionOne);
        buttonTwo.onClick.AddListener(optionTwo);
        buttonOne.GetComponentInChildren<TextMeshProUGUI>().SetText(buttonOneDescription);
        buttonTwo.GetComponentInChildren<TextMeshProUGUI>().SetText(buttonTwoDescription);
        gameObject.GetComponent<Collider>().enabled = false;

       // Destroy(gameObject);


    }
/*
    public void OnClick()
    {
        option.SetActive(true);
        TextHolder.textDescription = description;
        buttonOne.onClick.AddListener(optionOne);
        buttonTwo.onClick.AddListener(optionTwo);
        buttonOne.GetComponentInChildren<TextMeshProUGUI>().SetText(buttonOneDescription);
        buttonTwo.GetComponentInChildren<TextMeshProUGUI>().SetText(buttonTwoDescription);

    }
  
    */
    public void optionOne()
    {
        if (firstSelection == true)
        {
          
        
        
            Debug.Log("Good Choice");
            //Good Script
        }
        else
        {
            Debug.Log("Bad Choice");
        }
        //Debug.Log("1");
        option.SetActive(false);
        Destroy(gameObject);
    }
    public void optionTwo()
    {
        if (secondSelection == true)
        {
            Debug.Log("Good Choice");
            //Good Script
        }
        else
        {
            Debug.Log("Bad Choice");
        }
        //Debug.Log("2");
        option.SetActive(false); 
        Destroy(gameObject);
    }
}
