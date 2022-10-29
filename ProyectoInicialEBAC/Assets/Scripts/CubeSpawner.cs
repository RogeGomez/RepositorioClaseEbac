using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject prefabCube;
    public List<GameObject> cubeList;
    public float scaleFactor;
    public int numCubes = 0;

    void Start()
    {
        cubeList = new List<GameObject>();
    }

    void Update()
    {
        numCubes++;
        GameObject tempGameObject = Instantiate<GameObject>(prefabCube);
        tempGameObject.name = "Cubo Numero" + numCubes;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        cubeList.Add(tempGameObject);

        List<GameObject> objectsToDestroy = new List<GameObject>();

        foreach (GameObject go in cubeList)
        {
            float scale = go.transform.localScale.x;
            scale *= scaleFactor;
            go.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                objectsToDestroy.Add(go);
            }
        }

        foreach (GameObject go in objectsToDestroy)
        {
            cubeList.Remove(go);
            Destroy(go);
        }
    }
}
