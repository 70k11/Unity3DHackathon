using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void CheckIfKilled(Vector3 explosionPosition, float range)
    {
        float dist = (transform.position - explosionPosition).magnitude;
        if (dist > range)
        {
            //0
        }
        else
        {
            float force = 1.0f - dist / range;
            if(force > 0)
            {
                GetComponent<Renderer>().material.color = Color.black;
            }
        }
    }


}
