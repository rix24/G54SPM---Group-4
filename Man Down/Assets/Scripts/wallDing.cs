using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallDing : MonoBehaviour
{

    public AudioSource ding;

    // Start is called before the first frame update
    void Start()
    {
        ding = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.name == "Sphere")
        {
            ding.Play();
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            Debug.Log("Play SFX");
            ding.Play();
        }
    }
}
