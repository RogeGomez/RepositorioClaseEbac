using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    // Punto 1
    int intValue;
    float floatValue = 1;

    // Punto 2
    float a = 2;
    float b = 15;
    int c = 0;

    public string stringColor = "";

    void Start()
    {
        // Punto 2
        c = (int)(a + b);
        Debug.Log($"el resultado de {a} + {b} es igual a {c}");

        // Punto 4
        switch (stringColor)
        {
            case "Red":
                Debug.Log($"El color ha cambiado a {stringColor}");
                GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case "Grey":
                Debug.Log($"El color ha cambiado a {stringColor}");
                GetComponent<MeshRenderer>().material.color = Color.grey;
                break;
            case "Blue":
                Debug.Log($"El color ha cambiado a {stringColor}");
                GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
        }

        // Punto 5
        float d = 10.12345f;
        string numberToString = d.ToString("#.0000");
        Debug.Log(numberToString);

        // Punto 6
        //                 0123456_89012_456789 
        string fullName = "Rogelio Gomez Flores";

        string myName = fullName.Substring(0, 7);
        string surname1 = fullName.Substring(8, 5);
        string surname2 = fullName.Substring(14, 6);

        Debug.Log($"Mi nombre es {myName} mi primer apellido es {surname1} y mi segundo apellido es {surname2}");

        string[] nameSplit = fullName.Split();
        for (int i = 0; i < nameSplit.Length; i++)
        {
            Debug.Log(nameSplit[i]);
        }

        // Parte 2
        // Punto 1.
        string number1String = "1000";
        string number2String = "2000";
        int number1;
        int number2;

        bool parseCheck1 = int.TryParse(number1String, out number1);
        bool parseCheck2 = int.TryParse(number2String, out number2);

        if (parseCheck1 && parseCheck2)
        {
            Debug.Log("Parsing exitoso - la suma de los dos números es: " + (number1 + number2));
        }

        // Punto 2
        string text1 = "Hola Mundo";

        for (int i = 0; i < text1.Length; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log($"El caracter {text1[i]} es par");
            }
        }

        // Punto 3
        string text2 = "Hola Mundo en EBAC";
        string newText = text2.Substring(5);
        Debug.Log(newText);
    }

    void Update()
    {
        // Punto 1
        intValue++;
        Debug.Log(intValue);
    }

    void FixedUpdate()
    {
        // Punto 1
        floatValue *= 2;
        Debug.Log(floatValue);

        // Punto 3
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