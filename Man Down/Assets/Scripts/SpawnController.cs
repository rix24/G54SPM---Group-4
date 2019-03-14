using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{

    GameObject[] collectables;
    GameObject[] hazard;


    void Start()
    {

        collectables = GameObject.FindGameObjectsWithTag("Collectable");
        hazard = GameObject.FindGameObjectsWithTag("Hazard");

        //Debug.Log("collectables::" + collectables.Length);
        InvokeRepeating("RandomCollectables", 2.0f, 1.8f);
        InvokeRepeating("RandomHazard", 8.0f, 5f);

    }

    void RandomCollectables()
    {

        for (int i = 0; i < collectables.Length; i++)
        {
            collectables[i].SetActive(false);
            int randomCode = Random.Range(0, 4);
            GameObject newObj = collectables[randomCode];
            newObj.SetActive(true);
        }

    }

    void RandomHazard()
    {

        for (int i = 0; i < hazard.Length; i++)
        {
            hazard[i].SetActive(false);
            int randomCode = Random.Range(0, 4);
            GameObject newObj = hazard[randomCode];
            newObj.SetActive(true);
        }

    }
}