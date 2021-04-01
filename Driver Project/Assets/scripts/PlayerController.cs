using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnspeed;
    private float horizontalInput;
    private float forwardInput;
    private float jumpInput = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        jumpInput = Input.GetAxis("Jump");
        // Move the vehicle forward
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 20.0f;

        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 10.0f;
        }
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, horizontalInput);
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            transform.Translate(Vector3.up * jumpInput * 3);
        }
        
        
        


    }
}
