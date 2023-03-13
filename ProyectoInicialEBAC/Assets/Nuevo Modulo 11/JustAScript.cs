using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustAScript : MonoBehaviour
{
    [SerializeField] private int numberA = 1;
    [SerializeField] private int numberB = 1;
    [SerializeField] private string gameObjectNewName = "";
    [SerializeField] private GameObject _gameObject;

    private GameObject temporalPrefab;
    private Color colorRandom;

    private List<GameObject> myGameObjectList = new List<GameObject>();

    private void Start()
    {
        temporalPrefab = Instantiate(_gameObject, Vector3.zero, Quaternion.identity);
    }

    private void FixedUpdate()
    {
        RandomColorChanger();
    }

    private void Update()
    {
        if (temporalPrefab.GetComponent<MeshRenderer>().material.color.r < 0.5f)
        {
            GameObject temporalPrefabR = Instantiate(_gameObject, Vector3.right, Quaternion.identity);
            numberA++;
            temporalPrefabR.name = "r en más 0.5";
            myGameObjectList.Add(_gameObject);
        }
        else if (temporalPrefab.GetComponent<MeshRenderer>().material.color.g > 0.7f)
        {
            GameObject temporalPrefabG = Instantiate(_gameObject, Vector3.left, Quaternion.identity);
            numberB++;
            temporalPrefabG.name = "g en más 0.7";
            myGameObjectList.Add(_gameObject);
        }
    }

    private void RandomColorChanger()
    {
        colorRandom = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        _gameObject.GetComponent<MeshRenderer>().sharedMaterial.color = colorRandom;
    }
}
