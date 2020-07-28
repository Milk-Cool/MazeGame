using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyPlayer : MonoBehaviour
{
	public Vector3 losePos = new Vector3(60, (float)1.5, 0);
	public GameObject Player;
	bool il = false;
    void OnTriggerEnter()
     {
         il = true;
     }
     void Update(){
		 if(il) Player.transform.position = losePos;
		}
}
