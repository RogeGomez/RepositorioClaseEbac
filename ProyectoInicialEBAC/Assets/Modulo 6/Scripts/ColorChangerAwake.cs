using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerAwake : MonoBehaviour
{
    public GameObject cubeAwakePrefab;

    void Awake()
    {
        GameObject temp = Instantiate<GameObject>(cubeAwakePrefab);
        Color newColor = new Color(Random.value, Random.value, Random.value);
        temp.GetComponent<MeshRenderer>().material.color = newColor;
    }
}
