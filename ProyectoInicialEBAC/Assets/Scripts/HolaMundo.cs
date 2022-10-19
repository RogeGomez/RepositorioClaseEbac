using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;

    private void Awake()
    {
        Debug.Log("Soy el primero en despertar");
    }

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

    private void FixedUpdate()
    {
        Debug.LogWarning("Soy el FixedUpdate");
    }

    private void LateUpdate()
    {
        Debug.LogWarning("Y yo soy el LateUpdate");
    }
}
