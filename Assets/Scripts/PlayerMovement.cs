using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 10;
    private int count = 0;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI winText;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        DisplayText();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertictal = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertictal);

        rb.AddForce(movement * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            count += 1;
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            DisplayText();

        }
    }

    void DisplayText()
    {
        countText.text = "COUNT : " + count.ToString();

        if (count == 8)
        {
            winText.gameObject.SetActive(true);
        }
    }
}
