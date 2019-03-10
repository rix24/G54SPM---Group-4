using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour
{
  public Text scoreDisplayText,negScoreText;
	float scoreTimer=0f;
	float temp;
	bool flag=true;
	
	
    void Update()
	{
			if(flag==true){
				scoreTimer+=1;
				setScores(scoreTimer);
			}
    }
	public void setScores(float scores){
		scoreDisplayText.text = "Score : "+scores;
		temp=scores;
	}
	public void stopScore(){
		scoreDisplayText.text = "Score : "+temp;
		flag=false;
	}
	public void reduceScore(){
		Debug.Log("Temp::"+temp);
		negScoreText.text="You have hit the obstacle.You lost -100 points!";
		temp-=100;
		Debug.Log("Temp::"+temp);
		scoreDisplayText.text = "Score : "+temp;
		scoreTimer-=100;

	}
}
