using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour : MonoBehaviour
{
    Vector3 originalPos;
    private Quaternion originalRot;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        originalRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
                gameObject.transform.position = originalPos;
                gameObject.transform.rotation = originalRot;
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
}
