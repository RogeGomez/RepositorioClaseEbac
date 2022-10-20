using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerUpdate : MonoBehaviour
{
    public GameObject cubeUpdatePrefab;

    void Update()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value);
        GameObject temp = Instantiate<GameObject>(cubeUpdatePrefab);
        temp.GetComponent<MeshRenderer>().material.color = newColor;
    }
}
