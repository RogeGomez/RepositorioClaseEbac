using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger2 : MonoBehaviour
{
    public GameObject object1GO;
    public GameObject object2GO;

    public bool object1Status;
    public bool object2Status;

    void FixedUpdate()
    {
        object1Status = object1GO.GetComponent<ColorChanger>().object1;
        Debug.Log($"El estado del {object1GO.name} es {object1Status}");

        object2Status = object2GO.GetComponent<ColorChanger1>().object2;
        Debug.Log($"El estado del {object2GO.name} es {object2Status}");

        if (object1Status && object2Status)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}
