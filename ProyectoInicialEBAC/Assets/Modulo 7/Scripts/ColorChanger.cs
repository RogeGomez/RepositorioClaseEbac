using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    bool object1 = true;
    bool object2 = true;
    bool object3 = true;

    private void FixedUpdate()
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

        if (object3 && object2 && object1)
        {
            Debug.Log("El valor booleano del objeto1 es: " + object1);
            Debug.Log("El valor booleano del objeto2 es: " + object2);
        }
    }
}
