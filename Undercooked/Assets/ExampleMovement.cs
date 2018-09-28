using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMovement : MonoBehaviour {

    public int playerNumber;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Horizontal_" + playerNumber);

        float moveVertical = Input.GetAxis("Vertical_" + playerNumber);

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        GetComponent<Rigidbody2D>().AddForce(movement * 5.0f);

        if (Input.GetButton("Action_" + playerNumber)) {
            Debug.Log("|||||||||||||||||||||||ACTION!|||||||||||||||||||");
        }

    }
}
