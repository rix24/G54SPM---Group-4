using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ColiderController : MonoBehaviour
{
    public Text textc;
    // Start is called before the first frame update
    void Start()
    {
        randomGenerator();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collides"+other.gameObject.tag.ToString());
        if (other.gameObject.tag == "yellow" || other.gameObject.tag == "green" || other.gameObject.tag == "blue" || other.gameObject.tag == "orange")
        {
            textc.text = other.gameObject.tag.ToString();

        }

    }
     void OnCollisionExit(Collision other)
    {
        Debug.Log("Collidess");
       // Destroy(other.gameObject);
    }
    private void randomGenerator() {
        int randomColorCode = Random.Range(0, 4);
        Console.WriteLine(randomColorCode);
        String[] colorValue = new String[] { "Yellow", "Orange", "Green", "Blue"};
        textc.text = colorValue[randomColorCode];
       // Debug.Log("randomColorCode"+ randomColorCode);

    }
}
