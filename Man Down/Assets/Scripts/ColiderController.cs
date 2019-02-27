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
     void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collides11"+other.tag.ToString());
        if (other.tag == "yellow" || other.tag == "green" || other.tag == "blue" || other.tag == "orange")
        {
            textc.text = other.tag.ToString();

        }

    }
     void OnTriggerExit(Collider other)
    {
        Debug.Log("Collides");
        Destroy(other.gameObject);
    }
    private void randomGenerator() {
        int randomColorCode = Random.Range(0, 4);
        Console.WriteLine(randomColorCode);
        String[] colorValue = new String[] { "Yellow", "Orange", "Green", "Blue"};
        textc.text = colorValue[randomColorCode];
       // Debug.Log("randomColorCode"+ randomColorCode);

    }
}
