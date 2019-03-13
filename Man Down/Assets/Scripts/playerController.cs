using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float acceleration;
    private Rigidbody rBody;
    GameObject collectable,plane;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        plane = GameObject.Find("Plane");
        collectable = GameObject.Find("PickUps");

    }
    void FixedUpdate()
    {
        float verticalMove = Input.GetAxis("Vertical");
        float horizontalMove = Input.GetAxis("Horizontal");

        Vector3 controller = new Vector3(horizontalMove, 0.0f, verticalMove);

        rBody.AddForce(controller * acceleration);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            ScoreController scoreObj = plane.gameObject.GetComponent<ScoreController>();
            scoreObj.increaseScore();
        }
    }

}
