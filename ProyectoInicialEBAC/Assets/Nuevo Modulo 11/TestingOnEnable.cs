using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingOnEnable : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("Habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("Deshabilitado");
    }

    private void OnDestroy()
    {
        Debug.LogError("Destruido");
    }
}
