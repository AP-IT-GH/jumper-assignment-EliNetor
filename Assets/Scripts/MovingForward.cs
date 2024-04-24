using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingForward : MonoBehaviour
{
    public float speed = 1.0f; 

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
