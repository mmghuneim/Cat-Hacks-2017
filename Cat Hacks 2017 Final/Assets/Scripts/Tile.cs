﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    // member variables
    public int id;
    
    // constructor
    public Tile(int i) {
        id = i;
    }
    
    void onMouseDown() {
        Debug.Log("This tile was clicked!");
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
