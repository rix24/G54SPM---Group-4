using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreController : MonoBehaviour
{
  public Text scoreDisplayText,negScoreText,scorer;
    float scoreTimer=0f;
    float temp;
    bool flag=true;
    GameObject sphere,plane,panel;



void Start(){
	 panel =GameObject.Find("Panel");
		panel.gameObject.SetActive(false);
}
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
        sphere = GameObject.Find("Sphere");
        playerController endGame = sphere.gameObject.GetComponent<playerController>();
        endGame.GameEnd();
		panel.gameObject.SetActive(true);
				scorer.text =  "Your Score : "+temp;

	    //Application.LoadLevel(2);
        
    }
    public void increaseScore(){
        if (flag != false)
        {
            temp += 100;
            scoreDisplayText.text = "Score : " + temp;
            scoreTimer += 100;
        }
    
    }
	
    public void decreaseScore()
    {
        if (flag != false)
        {
            temp -= 100;
            scoreDisplayText.text = "Score : " + temp;
            scoreTimer -= 100;
        }
          
    }
}