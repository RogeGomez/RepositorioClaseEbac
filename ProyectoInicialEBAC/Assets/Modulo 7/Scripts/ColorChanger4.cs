using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger4 : MonoBehaviour
{
    public GameObject object1GO;
    public GameObject object2GO;

    public bool object1Status;
    public bool object2Status;

    void FixedUpdate()
    {
        object1Status = object1GO.GetComponent<ColorChanger2>().object1Status;

        object2Status = object2GO.GetComponent<ColorChanger3>().object2Status;

        if (object1Status && object2Status)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}
