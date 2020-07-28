using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KeyPickup : MonoBehaviour
{
	public int keysToPickup = 1;
	public int keyID = 1;
	public GameObject Door;
	bool il = false;
    public int[] keys = new int[100]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    //keyID max = 100
    void OnTriggerEnter()
     {
         il = true;
     }
     void Update(){
		 if(il){
			 keys[keyID]++;
			 if(keys[keyID] == keysToPickup){
				for(int i = 0; i < 400; i++) Door.transform.position = new Vector3(Door.transform.position.x, (float)Door.transform.position.y + (float).04, Door.transform.position.z);
			Destroy(Door);}
			Destroy(gameObject);}
			
		}
}
