using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private int count;
    public Text countText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * 10);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            if (other.GetComponent<Renderer>().material.color == Color.yellow)
            {
                other.gameObject.SetActive(false);
                count++;
                SetCountText();
            }
            else if (other.GetComponent<Renderer>().material.color == Color.white)
            {
                other.gameObject.SetActive(false);
                count = count + 5;
                SetCountText();
            }
            else if (other.GetComponent<Renderer>().material.color == Color.cyan)
            {
                other.gameObject.SetActive(false);
                count = count + 10;
                SetCountText();
            }

        }
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }
}
