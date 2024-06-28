using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    
    public Transform target;
    public Vector3 CameraFollow;

    void Update()
    {
        if (target != null)
        {
            transform.position = target.position + CameraFollow;
        }
    }
}
