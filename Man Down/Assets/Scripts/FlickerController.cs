using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using UnityEngine.UI;
using Random = UnityEngine.Random;
public class FlickerController : MonoBehaviour
{
	public Light flickerLight;
//	Light temp;
	//public GameObject wallColor;
    // Start is called before the first frame update
    void Start()
    {
        randomGenerator();
    }

    // Update is called once per frame
    void Update()
    {
 
    }
	 private void randomGenerator() {
        String[] colorValue = new String[] { "yellow", "orange", "green", "blue"};
       
		int randomColorCode=Random.Range(0,3);
			for(int i=0;i< randomColorCode;i++){
			Debug.Log("randomColorCode "+i+" "+colorValue[randomColorCode]);
			GameObject tagName = GameObject.FindWithTag(colorValue[randomColorCode]);
			//   textc.text = colorValue[randomColorCode];
			flickerLight=tagName.GetComponent<Light>();
			//if(temp!=null){temp.intensity=0;}
			Debug.Log("sdsd"+tagName.name);
			Debug.Log("spp"+flickerLight.name);
	flickerLight.GetComponent<Light>().enabled=!flickerLight.GetComponent<Light>().enabled;
			}		

			//if(tagName!=null){
				//temp=flickerLight;
			//}			

		
       // Debug.Log("randomColorCode"+ randomColorCode);

}
}
