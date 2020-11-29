using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Rotate(0, .5f, 0);
    }
}
