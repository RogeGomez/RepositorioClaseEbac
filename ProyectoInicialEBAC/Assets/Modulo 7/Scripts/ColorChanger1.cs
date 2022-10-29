using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger1 : MonoBehaviour
{
    public bool object2 = true;

    void FixedUpdate()
    {
        if (object2)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            object2 = false;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            object2 = true;
        }
    }
}
