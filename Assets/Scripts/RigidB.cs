using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidB : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = new Vector3(3, 4, 5);
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(position);
    }
}
