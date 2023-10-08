using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    Vector2 vec, vec2, son;
    void Start()
    {
        vec = new Vector2(5,3);
        vec2 = new Vector2(5, 7);
        son = 2 * vec + vec2;
        print(son);

    }

   
}
