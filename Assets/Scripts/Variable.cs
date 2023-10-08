using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    public int intensityValue;
    // Start is called before the first frame update
    void Start()
    {
        intensityValue = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowValue()
    {
        print("deðer : " + intensityValue);
    }
}
