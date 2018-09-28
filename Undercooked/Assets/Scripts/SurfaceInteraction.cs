using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfaceInteraction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("player entered");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("player on");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("player exited");
    }
}
