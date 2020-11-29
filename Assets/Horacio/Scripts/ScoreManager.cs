using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int goodCount;
    public static int badCount;
    public static int pinCount;
    public int options = 2;

    public string goodEndingScene;
    public string badEndingScene;

    public void Good()
    {
        goodCount++;
        Debug.Log("Good "+ goodCount);
    }
    public void Bad()
    {
        badCount++;
        Debug.Log("Bad " + badCount);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void End()
    {
        pinCount++;
        if (pinCount >= options)
        {
            if (goodCount < badCount)
            {
                Debug.Log("haahha bad ending");
                //SceneManager.LoadScene(goodEndingScene);
            }
            else
            {
                Debug.Log("good ending :3");
                //SceneManager.LoadScene(badEndingScene);
            }
        }
    }
}
