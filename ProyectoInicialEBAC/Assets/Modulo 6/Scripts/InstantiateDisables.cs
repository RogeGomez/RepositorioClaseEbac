using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateDisables : MonoBehaviour
{
    public GameObject cubePrefab;

    void OnEnable()
    {
        GameObject temp = Instantiate<GameObject>(cubePrefab);
    }

    void OnDisable()
    {
        GameObject temp = Instantiate<GameObject>(cubePrefab);
    }
}
