using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndScript : MonoBehaviour
{
	Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void RestartGame(){
 Application.LoadLevel(1);
	}
	public void DisplayScore(float scores){
		score.text = "Your Score : "+scores;
	}
}
