using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour
{
    private float liveTime = 0.5f; 
    void Start()
    {
        Destroy(gameObject, liveTime);
    }
}
