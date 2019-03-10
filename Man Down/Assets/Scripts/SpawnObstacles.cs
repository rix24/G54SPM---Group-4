	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
	public Transform[] Spawnpoint;
	public GameObject Prefab;
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
								foreach(Transform obj in Spawnpoint)
								{
									GameObject go = Instantiate(Prefab,obj.position,obj.rotation) as GameObject;

go.name = go.name.Replace("(Clone)", "");
								}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
