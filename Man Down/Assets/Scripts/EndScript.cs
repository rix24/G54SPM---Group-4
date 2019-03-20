using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndScript : MonoBehaviour
{
	Text score;
	GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
         panel =GameObject.Find("Panel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void RestartGame(){
                Application.LoadLevel(Application.loadedLevel);
				panel.gameObject.SetActive(false);
	}
	
}
