using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosDeCiclosYArreglos : MonoBehaviour
{
    void Start()
    {
        #region 1er Ejercicio
        #region Primer forma de hacer el ejercicio (mia)
        // Es la solución más complicada de las 3    
        // int[] a = new int[2];
        // int[] b = new int[2];

        // for (int i = 0; i < a.Length; i++)
        // {
        //     a[i] = Random.Range(1, 15);
        //     Debug.Log($"valores de a : {a[i]}");
        // }
        // for (int i = 0; i < b.Length; i++)
        // {
        //     b[i] = Random.Range(15, 25);
        //     Debug.Log($"valores de b : {b[i]}");
        // }

        // int[] c = new int[2];
        // for (int i = 0; i < c.Length; i++)
        // {
        //     c[i] = a[i] + b[i];
        // }
        // for (int i = 0; i < c.Length; i++)
        // {
        //     Debug.Log($"suma de a y b : {c[i]}");
        // }
        #endregion

        #region Segunda forma de hacer el ejercicio (Jesús y alguna modificación por mi)
        int[] a = new int[2];
        int[] b = new int[2];
        int[] c = new int[2];

        Debug.Log("-- PRIMER EJERCICIO --");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = Random.Range(1, 100);
            // Debug.Log($"Valores en A: {a[i]}");
            b[i] = Random.Range(1, 100);
            // Debug.Log($"Valores en B: {b[i]}");
        }

        for (int i = 0; i < c.Length; i++)
        {
            Debug.Log($"La suma de A:{a[i]} y B:{b[i]} es : {c[i] = a[i] + b[i]}");
        }
        #endregion

        #region Tercera forma de hacer el ejercicio (Jesús)
        // Otra forma es en un solo for, dando los valores random en la primer posición y sumándolos, luego pone los valores random de la segunda posición y los suma.
        // int[] a = new int[2];
        // int[] b = new int[2];
        // int[] c = new int[2];

        // for (int i = 0; i < a.Length; i++)
        // {
        //     a[i] = Random.Range(1, 15);
        //     b[i] = Random.Range(15, 25);
        //     c[i] = a[i] + b[i];

        //     Debug.Log($"Valor de a: {a[i]}");
        //     Debug.Log($"Valor de b: {b[i]}");
        //     Debug.Log($"Suma de a y b: {c[i]}");
        // }
        #endregion

        #endregion

        #region 2do Ejercicio
        string[] stringArray = { "Hola", "Mundo", "en", "la", "consola", "de", "Unity" };
        string newText = " ";

        Debug.Log("-- SEGUNDO EJERCICIO --");

        foreach (string simpleText in stringArray)
        {
            newText += " " + simpleText;
            Debug.Log(newText);
        }
        #endregion

        #region 3er Ejercicio
        int[,] arrayA = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[] arrayB = { 7, 8, 9 };
        int[,] arrayC = new int[2, 1];

        Debug.Log("-- TERCER EJERCICIO --");

        for (int i = 0; i < arrayA.GetLength(1); i++)
        {
            Debug.Log($"(D0) Multiplicación de {arrayA[0, i]} y {arrayB[i]} es : {arrayA[0, i] * arrayB[i]}");
            Debug.Log($"(D1) Multiplicación de {arrayA[1, i]} y {arrayB[i]} es : {arrayA[1, i] * arrayB[i]}");

            for (int j = 0; j < arrayC.Length; j++)
            {
                Debug.Log($"El resultado de la suma de c[{j}] es : {arrayC[j, 0] += arrayA[j, i] * arrayB[i]}");
            }
        }
        #endregion

        // Funciona con este for pero estoy fallando al principio DRY.
        // for (int i = 0; i < a.GetLength(1); i++)
        // {
        //     Debug.Log($"Multiplicación de {a[1, i]} y {b[i]} es : {a[1, i] * b[i]}");

        //     for (int j = 0; j < d.Length; j++)
        //     {
        //         Debug.Log($"El resultado de la suma es : {d[j] += a[1, i] * b[i]}");
        //     }
        // }

        // Esta solución es la que me puso Jesús en la plataforma.
        // int[,] a = { { 1, 2, 3 }, { 4, 5, 6 } };
        // int[] b = { 7, 8, 9 };
        // int[,] c = new int[2, 1];

        // for (int i = 0; i < a.GetLength(1); i++)
        // {
        //     for (int j = 0; j < c.Length; j++)
        //     {
        //         Debug.Log($"es el ciclo i: {i} | j: {j}");
        //         Debug.Log($"multiplicación de {a[j, i]} por {b[i]} es : {a[j, i] * b[i]}");
        //         Debug.Log($"la suma de c[{j}] es : {c[j, 0] += a[j, i] * b[i]}");
        //     }
        // }
    }
}