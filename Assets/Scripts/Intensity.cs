using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intensity : MonoBehaviour
{
    public GameObject cube;
    public Light thelight;
    void Start()
    {
        thelight.intensity = 2.5f;
    }

    private void Update()
    {
        //cube.GetComponent<Light>().intensity = GetComponent<Variable>().intensityValue;
        
    }
}
