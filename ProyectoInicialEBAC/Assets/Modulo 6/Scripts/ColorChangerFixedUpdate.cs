using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerFixedUpdate : MonoBehaviour
{
    void FixedUpdate()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = newColor;
    }
}
