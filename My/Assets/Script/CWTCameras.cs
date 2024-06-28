using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CWTCameras : MonoBehaviour
{
    public CWTCameras MainCamera;
    public CWTCameras MainCamera1;
    private bool isAltCameraActive = false;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {

            isAltCameraActive = !isAltCameraActive;

            MainCamera.gameObject.SetActive(!isAltCameraActive);
            MainCamera1.gameObject.SetActive(isAltCameraActive);
        }
    }
}
