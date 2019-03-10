using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{

     void Start()
    {
        GameObject currentObj = GameObject.Find("obstacle");
        if (currentObj != null) {
           
                }
    }
    void OnTriggerEnter(Collider other)
    {
           //    Destroy(other.gameObject);
       // Destroy(gameObject);
    }
}
