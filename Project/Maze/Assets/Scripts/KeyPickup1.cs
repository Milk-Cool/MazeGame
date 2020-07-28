using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KeyPickup1 : MonoBehaviour
{
	public GameObject Platform;
	int spos = 0;
	bool il = false;
    	void OnTriggerEnter()
     	{
         	il = true;
     	}
     	void Update(){
			if(il){
				if(spos != 400){
					Platform.transform.position = new Vector3(Platform.transform.position.x, (float)Platform.transform.position.y + (float).02, Platform.transform.position.z);
					++spos;
				}
			transform.position = new Vector3(0, -10, 0);}
			
		}
}
