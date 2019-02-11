using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Rotate the object around its local X axis at 1 degree per second
            transform.Rotate(new Vector3(0,0,-10));
        }
    }
}
