using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public float life = 2f;

    // Update is called once per frame
    void Update()
    {
        if(life > 0)
        {
            life -= Time.deltaTime;
            if(life<=0)
            {
                KillObj();
            }
        }
    }

    void KillObj()
    {
        Destroy(this.gameObject);
    }
}
