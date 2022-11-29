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

        #region Segunda forma de hacer el ejercicio (Jesús)
        // // En este código se imprime el resultado en la primer posición a y b, luego la segunda posición de a y b y al final la suma de la posición 1 y 2.
        // int[] a = new int[2];
        // int[] b = new int[2];
        // int[] c = new int[2];

        // for (int i = 0; i < a.Length; i++)
        // {
        //     a[i] = Random.Range(1, 15);
        //     Debug.Log($"Valores en A: {a[i]}");
        //     b[i] = Random.Range(1, 15);
        //     Debug.Log($"Valores en B: {b[i]}");
        // }

        // for (int i = 0; i < c.Length; i++)
        // {
        //     c[i] = a[i] + b[i];
        //     Debug.Log(c[i]);
        // }
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
        // string[] stringArray = { "Hola", "Mundo", "en", "la", "consola", "de", "Unity" };
        // string newText = " ";

        // foreach (string simpleText in stringArray)
        // {
        //     newText += " " + simpleText;
        //     Debug.Log(newText);
        // }
        #endregion

        #region 3er Ejercicio
        int[,] a = { { 1, 2, 3 }, { 4, 5, 6 } };
        int[] b = { 7, 8, 9 };
        int[,] c = new int[2, 1];

        for (int i = 0; i < a.GetLength(1); i++)
        {
            Debug.Log($"(D0) Multiplicación de {a[0, i]} y {b[i]} es : {a[0, i] * b[i]}");
            Debug.Log($"(D1) Multiplicación de {a[1, i]} y {b[i]} es : {a[1, i] * b[i]}");

            for (int j = 0; j < c.Length; j++)
            {
                Debug.Log($"El resultado de la suma es : {c[j, i] += a[1, j] * b[i]}");
            }
        }

        // for (int i = 0; i < a.GetLength(1); i++)
        // {
        //     Debug.Log($"Multiplicación de {a[1, i]} y {b[i]} es : {a[1, i] * b[i]}");

        //     for (int j = 0; j < d.Length; j++)
        //     {
        //         Debug.Log($"El resultado de la suma es : {d[j] += a[1, i] * b[i]}");
        //     }
        // }
        #endregion
    }
}