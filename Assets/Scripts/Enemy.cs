using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    UIManager currentUIManager;

    public void Init(UIManager uIManager)
    {
        currentUIManager = uIManager;
    }

    public void CheckIfKilled(Vector3 explosionPosition, float range)
    {
        float dist = (transform.position - explosionPosition).magnitude;
        if (dist > range)
        {
            //GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            float force = 1.0f - dist / range;
            if(force > 0.5)
            {
                //GetComponent<Renderer>().material.color = Color.black;
                Destroy(gameObject);
                
            }
        }
        currentUIManager?.Hit();
    }


}
