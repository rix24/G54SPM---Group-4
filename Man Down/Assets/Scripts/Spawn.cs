using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject c1,c2,c3,c4;

    // Start is called before the first frame update
    void Start()
    {
        c1 = GameObject.Find("Collectable1");
        c2 = GameObject.Find("Collectable2");
        c3 = GameObject.Find("Collectable3");
        c4 = GameObject.Find("Collectable4");

    }

    // Update is called once per frame
    void Update()
    {
       /* int rnd = Random.Range(0, 200);
        if (rnd == 1)
        {
            Instantiate(c1);
        }
        else if (rnd == 2)
        {
            Instantiate(c2);
        }
        else if (rnd == 3)
        {
            Instantiate(c3);
        }
        else if (rnd == 4)
        {
            Instantiate(c4);
        }*/
    }
}
