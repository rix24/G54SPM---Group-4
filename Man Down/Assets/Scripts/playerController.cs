using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float acceleration;
    private Rigidbody rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float verticalMove = Input.GetAxis("Vertical");
        float horizontalMove = Input.GetAxis("Horizontal");

        Vector3 controller = new Vector3(horizontalMove, 0.0f, verticalMove);

        rBody.AddForce(controller * acceleration);

    }
}
