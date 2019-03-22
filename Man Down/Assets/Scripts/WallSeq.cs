using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSeq : MonoBehaviour
{
    GameObject eWY, sWY, wWG, nWG, eWB, nWB, wWO, sWO,plane;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        int life = 1;
        Debug.Log("Game Started!");
        float x = 1;
        wWG = GameObject.Find("westWallGreen");
        nWG = GameObject.Find("northWallGreen");
        eWY = GameObject.Find("eastWallYellow");
        sWY = GameObject.Find("southWallYellow");
        eWB = GameObject.Find("eastWallBlue");
        nWB = GameObject.Find("northWallBlue");
        wWO = GameObject.Find("westWallOrange");
        sWO = GameObject.Find("southWallOrange");
		plane = GameObject.Find("Plane");
		
        while (life == 1)
        {   

            int diceroll = Random.Range(1,9);

            if((wWG.gameObject.GetComponent<Renderer>().material.color == Color.red) && (nWG.gameObject.GetComponent<Renderer>().material.color == Color.red) && (eWY.gameObject.GetComponent<Renderer>().material.color == Color.red) && (sWY.gameObject.GetComponent<Renderer>().material.color == Color.red) && (eWB.gameObject.GetComponent<Renderer>().material.color == Color.red) && (nWB.gameObject.GetComponent<Renderer>().material.color == Color.red) && (wWO.gameObject.GetComponent<Renderer>().material.color == Color.red) && (sWO.gameObject.GetComponent<Renderer>().material.color == Color.red))
            {
                life = 0;
				ScoreController scoreObj = plane.gameObject.GetComponent<ScoreController>();
				scoreObj.stopScore();
            }

            if (diceroll == 1)
            {
                wWG.gameObject.GetComponent<Renderer>().material.color = Color.red;
            } 
            else if (diceroll == 2)
            {
                nWG.gameObject.GetComponent<Renderer>().material.color = Color.red;
            } 
            else if (diceroll == 3) {
                eWY.gameObject.GetComponent<Renderer>().material.color = Color.red;
            } 
            else if (diceroll == 4){
                sWY.gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            else if (diceroll == 5){
                eWB.gameObject.GetComponent<Renderer>().material.color = Color.red;
            } 
            else if (diceroll == 6){
                nWB.gameObject.GetComponent<Renderer>().material.color = Color.red;
            } 
            else if (diceroll == 7){
                wWO.gameObject.GetComponent<Renderer>().material.color = Color.red;
            } 
            else if (diceroll == 8){
                sWO.gameObject.GetComponent<Renderer>().material.color = Color.red;
            }
            if (x >= 0.25F)
            {
                x -= 0.005F;
            }
            yield return new WaitForSeconds(x);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
