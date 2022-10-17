using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;

    void Start()
    {
        x = 10;
        Debug.Log("Hola Mundo");
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Algo salio muy mal");
    }

    void Update()
    {
        x++;
        Debug.Log(x);
    }
}
