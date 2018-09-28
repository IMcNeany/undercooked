﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMovement : MonoBehaviour {

    public int playerNumber;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 movement = new Vector2(
            GetComponent<InputManager>().getHorizontal(),
            GetComponent<InputManager>().getVertical()
            );

        GetComponent<Rigidbody2D>().AddForce(movement * 5.0f);

        //if (Input.GetButton("Action_" + playerNumber))
        //{
        //    Debug.Log("|||||||||||||||||||||||ACTION!|||||||||||||||||||");
        //}

    }
}
