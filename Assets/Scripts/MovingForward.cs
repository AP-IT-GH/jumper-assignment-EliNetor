using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingForward : MonoBehaviour
{
    public float minSpeed = 1.0f; 
    public float maxSpeed = 5.0f;
    private float speed;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }
    void Update()
    { 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
