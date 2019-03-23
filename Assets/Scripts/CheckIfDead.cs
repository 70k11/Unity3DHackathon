using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfDead : MonoBehaviour
{
    public Rigidbody CubeRb;
    void Start()
    {
        CubeRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
       
    }
}
