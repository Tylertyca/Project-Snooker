using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, -0.02f);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, 0.02f);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(0.02f, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(-0.02f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 3, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -3, 0);
        }
    }
}
