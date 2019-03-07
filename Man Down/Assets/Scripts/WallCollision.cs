using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{   
    GameObject eWY,sWY,wWG,nWG,eWB,nWB,wWO,sWO;

    private IEnumerator OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.name == "westWallGreen" || collisionInfo.gameObject.name == "northWallGreen")
        {
            Color green = new Color32(26, 236, 23, 1);
            Color greena = new Color32(89, 244, 95, 1);
            wWG = GameObject.Find("westWallGreen");
            nWG = GameObject.Find("northWallGreen");
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = greena;
            yield return new WaitForSeconds(2);
            wWG.gameObject.GetComponent<Renderer>().material.color = green;
            nWG.gameObject.GetComponent<Renderer>().material.color = green;
        }
        if (collisionInfo.gameObject.name == "eastWallYellow" || collisionInfo.gameObject.name == "southWallYellow")
        {
            Color yellow = new Color32(222, 231, 19, 1);
            Color yellowa = new Color32(243, 253, 88, 1);
            eWY = GameObject.Find("eastWallYellow");
            sWY = GameObject.Find("southWallYellow");
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = yellowa;
            yield return new WaitForSeconds(2);
            eWY.gameObject.GetComponent<Renderer>().material.color = yellow;
            sWY.gameObject.GetComponent<Renderer>().material.color = yellow;

        }
        if (collisionInfo.gameObject.name == "eastWallBlue" || collisionInfo.gameObject.name == "northWallBlue")
        {
            Color blue = new Color32(44, 80, 207, 1);
            Color bluea = new Color32(91, 129, 244, 1);
            eWB = GameObject.Find("eastWallBlue");
            nWB = GameObject.Find("northWallBlue");
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = bluea;
            yield return new WaitForSeconds(2);
            eWB.gameObject.GetComponent<Renderer>().material.color = blue;
            nWB.gameObject.GetComponent<Renderer>().material.color = blue;
        }
        if (collisionInfo.gameObject.name == "westWallOrange" || collisionInfo.gameObject.name == "southWallOrange")
        {
            Color orange = new Color32(248, 151, 11, 2);
            Color orangea = new Color32(253, 190, 77, 2);

            wWO = GameObject.Find("westWallOrange");
            sWO = GameObject.Find("southWallOrange");
            collisionInfo.gameObject.GetComponent<Renderer>().material.color = orangea;
            yield return new WaitForSeconds(2);
            wWO.gameObject.GetComponent<Renderer>().material.color = orange;
            sWO.gameObject.GetComponent<Renderer>().material.color = orange;
        }
    }
}
