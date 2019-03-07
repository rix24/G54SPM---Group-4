using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    private void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {   
        if(collisionInfo.gameObject.name == "eastWallYellow" || collisionInfo.gameObject.name == "southWallYellow")
        {
            //Debug.Log(collisionInfo.collider.name);
            Debug.Log("Yellow wall hit");
        }
        if (collisionInfo.gameObject.name == "westWallGreen" || collisionInfo.gameObject.name == "northWallGreen")
        {
            //Debug.Log(collisionInfo.collider.name);
            Debug.Log("Green wall hit");
        }
        if (collisionInfo.gameObject.name == "eastWallBlue" || collisionInfo.gameObject.name == "northWallBlue")
        {
            //Debug.Log(collisionInfo.collider.name);
            Debug.Log("Blue wall hit");
        }
        if (collisionInfo.gameObject.name == "westWallOrange" || collisionInfo.gameObject.name == "southWallOrange")
        {
            //Debug.Log(collisionInfo.collider.name);
            Debug.Log("Orange wall hit");
        }
        //yield return new WaitForSeconds(2);
    }

}
