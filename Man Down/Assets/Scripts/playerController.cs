﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerController : MonoBehaviour
{
    public float acceleration;
    private Rigidbody rBody;
    GameObject collectable,plane;
    bool move = true;
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
        if(move == false)
        {
            acceleration = 0;
        }
        rBody.AddForce(controller * acceleration);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            ScoreController scoreObj = plane.gameObject.GetComponent<ScoreController>();
            scoreObj.increaseScore();
        }/*else if (other.gameObject.CompareTag("Hazard"))
        {
            //other.gameObject.SetActive(false);
            ScoreController scoreObj = plane.gameObject.GetComponent<ScoreController>();
            scoreObj.decreaseScore();
        }*/
    }
    private void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.name == "ObstacleY" || collisionInfo.gameObject.name == "ObstacleO" || collisionInfo.gameObject.name == "ObstacleG" || collisionInfo.gameObject.name == "ObstacleB")
        {
            ScoreController scoreObj = plane.gameObject.GetComponent<ScoreController>();
            scoreObj.decreaseScore();
        }
    }
    public void GameEnd()
    {
        move=false;
    }
}