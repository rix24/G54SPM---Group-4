﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void PlayGame(){
		Debug.Log("plays");
  Application.LoadLevel(1);	}
	public void QuitGame(){
 Application.Quit();	}
}
