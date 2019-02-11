using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{

    Vector3 originalPos;
    Vector3 topPos;
    private Quaternion originalRot;
    private Quaternion topRot;


    // Use this for initialization
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        topPos = new Vector3(0.4f, 15.9f, -7f);
        originalRot = transform.rotation;
        topRot = Quaternion.Euler(70, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        SwitchCamera();
    }


    //Change Camera Keyboard
    void SwitchCamera()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            CameraChangeCounter();
        }
    }

    //Camera Counter
    void CameraChangeCounter()
    {
        int CameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        CameraPositionCounter++;
        CameraPositionChange(CameraPositionCounter);
    }

    //Camera change Logic
    void CameraPositionChange(int CamPosition)
    {
        if (CamPosition > 1)
        {
            CamPosition = 0;
        }

        //Set camera position database
        PlayerPrefs.SetInt("CameraPosition", CamPosition);

        //Set camera position 1
        if (CamPosition == 0)
        {
            Camera.main.transform.position = topPos;
            Camera.main.transform.rotation = topRot;
        }

        //Set camera position 2
        if (CamPosition == 1)
        {
            Camera.main.transform.position = originalPos;
            Camera.main.transform.rotation = originalRot;
        }

    }
}
