using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderScript : MonoBehaviour
{
    // Start is called before the first frame update
	GameObject panel;
    void Start()
    {
        panel =GameObject.Find("Panel");
		panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void PlayGame(){
		Debug.Log("plays");
  Application.LoadLevel(1);	}
	public void Help(){
		panel.gameObject.SetActive(true);
	}
	public void CloseHelp(){
				panel.gameObject.SetActive(false);

	}
}
