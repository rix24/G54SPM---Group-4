using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{   
    GameObject eWY,sWY,wWG,nWG,eWB,nWB,wWO,sWO,obstacle,plane;

    private IEnumerator OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        Color green = new Color32(26, 236, 23, 1);
        Color greena = new Color32(89, 244, 95, 1);
        Color yellow = new Color32(222, 231, 19, 1);
        Color yellowa = new Color32(243, 253, 88, 1);
        Color blue = new Color32(44, 80, 207, 1);
        Color bluea = new Color32(91, 129, 244, 1);
        Color orange = new Color32(248, 151, 11, 2);
        Color orangea = new Color32(253, 190, 77, 2);

        wWG = GameObject.Find("westWallGreen");
        nWG = GameObject.Find("northWallGreen");
        eWY = GameObject.Find("eastWallYellow");
        sWY = GameObject.Find("southWallYellow");
        eWB = GameObject.Find("eastWallBlue");
        nWB = GameObject.Find("northWallBlue");
        wWO = GameObject.Find("westWallOrange");
        sWO = GameObject.Find("southWallOrange");
	   obstacle = GameObject.Find("obstacle");
	   plane = GameObject.Find("Plane");
	   
		  

        if (collisionInfo.gameObject.name == "westWallGreen")
        { 
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = greena;
            yield return new WaitForSeconds(0.2F);
            wWG.gameObject.GetComponent<Renderer>().material.color = green;
        } else if(collisionInfo.gameObject.name == "northWallGreen")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = greena;
            yield return new WaitForSeconds(0.2F);
            nWG.gameObject.GetComponent<Renderer>().material.color = green;
        } else if (collisionInfo.gameObject.name == "eastWallYellow")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = yellowa;
            yield return new WaitForSeconds(0.2F);
            eWY.gameObject.GetComponent<Renderer>().material.color = yellow;
        } else if (collisionInfo.gameObject.name == "southWallYellow")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = yellowa;
            yield return new WaitForSeconds(0.2F);
            sWY.gameObject.GetComponent<Renderer>().material.color = yellow;
        } else if (collisionInfo.gameObject.name == "eastWallBlue")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = bluea;
            yield return new WaitForSeconds(0.2F);
            eWB.gameObject.GetComponent<Renderer>().material.color = blue;
        } else if (collisionInfo.gameObject.name == "northWallBlue")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = bluea;
            yield return new WaitForSeconds(0.2F);
            nWB.gameObject.GetComponent<Renderer>().material.color = blue;
        } else if (collisionInfo.gameObject.name == "westWallOrange")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = orangea;
            yield return new WaitForSeconds(0.2F);
            wWO.gameObject.GetComponent<Renderer>().material.color = orange;
        } else if (collisionInfo.gameObject.name == "southWallOrange")
        {
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = orangea;
            yield return new WaitForSeconds(0.2F);
            sWO.gameObject.GetComponent<Renderer>().material.color = orange;
        }else if (collisionInfo.gameObject.name == "obstacle"){
			Debug.Log("Collidess");
			Destroy(collisionInfo.gameObject);
		//ScoreController scoreObj = plane.gameObject.GetComponent<ScoreController>();
				//scoreObj.reduceScore();
			
		}
    }
	 
}
