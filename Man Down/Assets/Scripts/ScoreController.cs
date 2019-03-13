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
	
	
    void Update(){
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
	public void increaseScore(){
		temp+=100;
		scoreDisplayText.text = "Score : "+temp;
		scoreTimer+=100;
	}
    public void decreaseScore()
    {
        temp -= 100;
        scoreDisplayText.text = "Score : " + temp;
        scoreTimer -= 100;
    }
}
