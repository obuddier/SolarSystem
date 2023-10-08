using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector3 donus;
    void Update()
    {
        GetComponent<Transform>().Rotate(donus);       
    }
}
