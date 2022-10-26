using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public bool object1 = true;

    void FixedUpdate()
    {
        if (object1)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            object1 = false;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            object1 = true;
        }
    }
}
