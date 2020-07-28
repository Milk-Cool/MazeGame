using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KeyPickup2 : MonoBehaviour
{
	public GameObject Platform;
	int spos = 0;
	bool il = false;
    	void OnTriggerEnter(){
         	il = true;
     	}
     	void Update(){
			if(il){
				Platform.GetComponent<Rigidbody>().useGravity = true;
				Platform.GetComponent<Rigidbody>().isKinematic = false;
			
			transform.position = new Vector3(0, -10, 0);}
			
		}
}
