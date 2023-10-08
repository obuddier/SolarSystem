using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCol : MonoBehaviour
{

    void Update()
    {
        print(GetComponent<BoxCollider>().bounds.max);
    }
}

  
