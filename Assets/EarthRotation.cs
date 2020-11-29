using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthRotation : MonoBehaviour
{
    public Text dayText;
    int dayNum = 0;
    public int seconds = 15;

    void Start()
    {
        dayText = FindObjectOfType<Text>();
    }

    void FixedUpdate()
    {
        dayText.text = "Day: " + dayNum;
        gameObject.transform.Rotate(0, .5f, 0);
        StartCoroutine(Count());
    }

    IEnumerator Count()
    {
        yield return new WaitForSeconds(14);
        dayCount();
        StopAllCoroutines();
    }

    void dayCount()
    {
        dayText.text = "Day: " + dayNum++;
    }
}
