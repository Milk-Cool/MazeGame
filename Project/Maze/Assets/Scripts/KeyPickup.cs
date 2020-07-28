using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KeyPickup : MonoBehaviour
{
	public GameObject Door;
	int spos = 0;
	bool il = false;
    	void OnTriggerEnter(){
         	il = true;
     	}
     	void Update(){
			if(il){
				if(spos != 400){
					Door.transform.position = new Vector3(Door.transform.position.x, (float)Door.transform.position.y + (float).04, Door.transform.position.z);
					++spos;
				}else{
					Destroy(Door);
				}
			transform.position = new Vector3(0, -10, 0);}
			
		}
}
