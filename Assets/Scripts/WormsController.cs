using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController : MonoBehaviour
{
    public Rigidbody rb;
    public Rigidbody rb2;
    public float ammospeed;
    public float jumpForce;
    public float moveForce;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 force = new Vector3(0, jumpForce, 0);
            rb.AddForce(force);
            Debug.Log("Space Taste ist gedrueckt");
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 go = new Vector3(moveForce, 0, 0);
            rb.AddForce(go);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 goback = new Vector3(-moveForce, 0, 0);
            rb.AddForce(goback);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Rigidbody clone;
            Vector3 dings = new Vector3(0.5f, 0.5f, 0f);
            clone = Instantiate(rb2, transform.position + dings, transform.rotation);
            clone.velocity = transform.TransformDirection(ammospeed, 0, 0);
            Vector3 kraft = new Vector3(ammospeed, 0, 0);
            rb.AddForce(kraft);
        }

    
    }

}
