using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject cube;
    private Transform cubeTransform;
    private float zPos = 0;


    // Start is called before the first frame update
    void Start()
    {
        cubeTransform = cube.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        cubeTransform.position = new Vector3(0, 0, 1);
        zPos += 0.1f;
    }
}
