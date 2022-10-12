using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementREAL : MonoBehaviour
{


    // public Rigidbody rb;

    //public CharacterController controller;

    public float speed = 6f;

    void Start()
    {
        //   rb.AddForce(0,200,500);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // rb.AddForce(0,0,2000 * Time.deltaTime);

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        // if (direction.magnitude >= 0.1f)
        // {
        //    controller.Move(direction * speed * Time.deltaTime);

        //}

        transform.Translate(new Vector3(horizontal * Time.deltaTime * 3f, 0, vertical * Time.deltaTime * 3f));


    }
}
