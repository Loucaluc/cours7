﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathParticule : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}