using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EjercicioEstructuras : MonoBehaviour
{
    private void Start()
    {
        MethodTesting(2, 6, 10); // Primer Ejercicio
        descendentNumbers(); // Segundo Ejercicio
        duplicatedNumbers(); // Tercer Ejercicio
        ListOfNames(); // Cuarto Ejercicio
    }

    // Primer Ejercicio
    public List<int> numbersList = new List<int>();
    void MethodTesting(int a, int b, int c)
    {
        Debug.Log("Primer Ejercicio");
        for (int i = 0; i < a; i++)
        {
            numbersList.Add(UnityEngine.Random.Range(b, c));
        }
        foreach (int numbersCount in numbersList)
        {
            Debug.Log($"los números son : {numbersCount}");
        }
    }

    // Segundo Ejercicio
    int[] arrayOfNumbers = { 2, 4, 10, 1, 9, 8, 22 };
    void descendentNumbers()
    {
        Debug.Log("Segundo Ejercicio");
        foreach (int numbers in arrayOfNumbers)
        {
            // Debug.Log($"Orden original: {numbers}");
        }
        Array.Sort(arrayOfNumbers);
        foreach (int numbers in arrayOfNumbers)
        {
            // Debug.Log($"Ordenados: {numbers}");
        }
        Array.Reverse(arrayOfNumbers);
        foreach (int numbers in arrayOfNumbers)
        {
            Debug.Log($"Orden descendente: {numbers}");
        }
    }

    // Tercer Ejercicio
    void duplicatedNumbers()
    {
        List<int> numbersList = new List<int>() { 2, 8, 20, 2, 10, 2, 5, 4, 7 };
        numbersList.Sort();
        Debug.Log("Tercer Ejercicio");
        var noDupesNumbers = numbersList.Distinct();

        foreach (int numbers in noDupesNumbers)
        {
            Debug.Log(numbers);
        }
    }

    // Cuarto Ejercicio
    Stack<string> nameStack = new Stack<string>();
    Queue<string> queueStrings = new Queue<string>();
    void ListOfNames()
    {
        nameStack.Push("Hugo");
        nameStack.Push("Carlos");
        nameStack.Push("Juan");
        Debug.Log(nameStack.Peek());
        nameStack.Pop();
        Debug.Log(nameStack.Peek());
        nameStack.Pop();
        Debug.Log(nameStack.Peek());

        queueStrings.Enqueue("Luis");
        queueStrings.Enqueue("Manuel");
        queueStrings.Enqueue("Jose");
        Debug.Log(queueStrings.Peek());
        queueStrings.Dequeue();
        Debug.Log(queueStrings.Peek());
        queueStrings.Dequeue();
        Debug.Log(queueStrings.Peek());
    }
}
