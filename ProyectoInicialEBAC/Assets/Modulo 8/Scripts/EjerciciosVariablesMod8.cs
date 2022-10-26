using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    int intValue;
    float floatValue = 1;

    float a = 2;
    float b = 15;
    int c = 0;

    void Start()
    {
        c = (int)(a + b);
        // Debug.Log($"el resultado de {a} + {b} es igual a {c}");
    }

    void Update()
    {
        intValue++;
        // Debug.Log(intValue);
    }

    void FixedUpdate()
    {
        floatValue *= 2;
        // Debug.Log(floatValue);

        intValue = Random.Range(1, 10);
        if (intValue % 2 == 0)
        {
            Debug.Log($"{intValue} es par");
            GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else
        {
            Debug.Log($"{intValue} es impar");
            GetComponent<MeshRenderer>().material.color = Color.grey;
        }
    }
}
