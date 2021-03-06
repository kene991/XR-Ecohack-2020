﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class OptionDescription : MonoBehaviour
{
    public AudioSource goodClip;
    public AudioSource badClip;
    public string description;

    public GameObject option, option2, option3;
    public Button buttonOne;
    public string buttonOneDescription;
    public bool firstSelection =  false; 
    public Button buttonTwo;
    public string buttonTwoDescription;
    public bool secondSelection = false;
    bool good = false;

    private void Start()
    {
    }

    private void OnMouseDown()
    {
        
        ScoreManager.pinCount++;
        option.SetActive(true);
        TextHolder.textDescription = description;
        buttonOne.onClick.AddListener(optionOne);
        buttonTwo.onClick.AddListener(optionTwo);
        buttonOne.GetComponentInChildren<TextMeshProUGUI>().SetText(buttonOneDescription);
        buttonTwo.GetComponentInChildren<TextMeshProUGUI>().SetText(buttonTwoDescription);
        gameObject.GetComponent<Collider>().enabled = false;
    }

    public void optionOne()
    {
        if (firstSelection == true)
        {
            goodClip.Play();
            option2.SetActive(true);
            Debug.Log("option1ifstatement");
            //Good Script
            ScoreManager.goodCount++;
            Debug.Log("Good " + ScoreManager.goodCount);
        }
        else
        {
            badClip.Play();
            Debug.Log("option1elsestatement");
            ScoreManager.badCount++;
            Debug.Log("bad " + ScoreManager.badCount);
        }
        //Debug.Log("1");
        option.SetActive(false);
        Destroy(gameObject);
    }

    public void optionTwo()
    {
        if (secondSelection == true)
        {
            goodClip.Play();
            Debug.Log("Good Choice");
            Debug.Log("Good " + ScoreManager.goodCount);
            //Good Script
        }
        else
        {
            badClip.Play();
            option3.SetActive(true);
            Debug.Log("Bad Choice");
            Debug.Log("bad " + ScoreManager.badCount);
        }
        //Debug.Log("2");
        option.SetActive(false); 
        Destroy(gameObject);

    }
}
