﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTriggerScript : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		if(collider.tag=="Player"){
			Destroy(collider.gameObject);
		}

		if(collider.tag=="Enemy"){
			Destroy(collider.gameObject);	
		}
	}

	
}
