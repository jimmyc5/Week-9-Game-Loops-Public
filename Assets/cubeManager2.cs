using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeManager2 : MonoBehaviour
{
    public GameObject cubeToSpawn;
    private List<GameObject> cubes;
    // Start is called before the first frame update
    void Start()
    {
        cubes = new List<GameObject>();
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    GameObject newCube = GameObject.Instantiate(cubeToSpawn, new Vector3(i * 2f, k * 2f, j * 2f), Quaternion.identity);
                    newCube.GetComponent<rotate2>().startingOffset = j;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
