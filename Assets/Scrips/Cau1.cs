using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cau1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("C");
        }
    }
}
