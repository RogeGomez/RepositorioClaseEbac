using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class JustAScript : MonoBehaviour
{
    [SerializeField] private int numberA = 1;
    [SerializeField] private int numberB = 1;
    [SerializeField] private string listToString = "";
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private List<GameObject> myGameObjectList = new List<GameObject>();

    private GameObject temporalPrefab;
    private bool isRemoving = false;

    private void Start()
    {
        // Punto 5
        temporalPrefab = Instantiate(_gameObject, Vector3.zero, Quaternion.identity);
        temporalPrefab.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }

    private void FixedUpdate()
    {
        listToString = myGameObjectList.Count.ToString();
        if (int.Parse(listToString) >= 5)
        {
            // Debug.Log(listToString);
            // Debug.Log(myGameObjectList[2].gameObject.name);
            // Debug.Log(myGameObjectList[0].gameObject.name.Substring(0, 1));
            Debug.Log($"{listToString}, {myGameObjectList[2].name}, {myGameObjectList[0].name.Substring(0, 1)}");
        }
        else
        {
            Debug.Log("");
        }
    }

    private void Update()
    {
        if (temporalPrefab.GetComponent<MeshRenderer>().material.color.r < 0.5f)
        {
            GameObject temporalPrefabR = Instantiate(_gameObject, Vector3.right, Quaternion.identity);
            numberA++;
            temporalPrefabR.name = "r en más 0.5";
            myGameObjectList.Add(temporalPrefabR);
        }
        else if (temporalPrefab.GetComponent<MeshRenderer>().material.color.g > 0.7f)
        {
            GameObject temporalPrefabG = Instantiate(_gameObject, Vector3.left, Quaternion.identity);
            numberB++;
            temporalPrefabG.name = "g en más 0.7";
            myGameObjectList.Add(temporalPrefabG);
        }

        // punto 7
        if (myGameObjectList.Count > 5 && isRemoving == false)
        {
            isRemoving = true;
            for (int i = myGameObjectList.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    myGameObjectList.RemoveAt(i);
                }
            }
            isRemoving = false;
        }
    }
}
