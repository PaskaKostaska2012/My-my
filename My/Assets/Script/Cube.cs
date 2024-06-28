using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private Vector3 moveVector;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        moveVector.x=Input.GetAxis("Horizontal");
        moveVector.z=Input.GetAxis("Vertical");
        rb.MovePosition(rb.position+moveVector*speed*Time.deltaTime);
    }
}
