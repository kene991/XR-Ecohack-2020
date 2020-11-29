using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTextIp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, 2, 0);
        if (transform.localPosition.y >= 2000)
        {
            transform.localPosition = new Vector3(0, -1416, 0);
        }
    }
}
