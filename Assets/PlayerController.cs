using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 1;
    public Rigidbody rb;
    public float jumpForce = 300;
    public  Text CounterValue;
    public static int counterForScore = 0;
    void Update()
    {
        var posChar = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal")) * speed;
        posChar.y = rb.velocity.y;
        rb.velocity = posChar;

        if (Input.GetKeyDown(KeyCode.Space)) rb.AddForce(Vector3.up * jumpForce);
    }

    public  int count;

    private void OnTriggerEnter(Collider other)
    {
        
        if (gameObject.tag == "Player" && other.tag == "Bananas")
        {

            count++;
            counterForScore++;
            Destroy(other.gameObject);
            Debug.Log("One");
            CounterValue.text = "Score : " + counterForScore.ToString();

            if (count >= 3)
            {
                GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(true);
                count = 0;
               

            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        
    }


}
