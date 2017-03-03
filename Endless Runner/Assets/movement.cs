using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    float speed = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.Translate(0, speed, 0);
        if (Input.GetKey("up")) 
        {
            speed = .05f;
        }
        if (Input.GetKey("down"))
        {
            speed = -.05f;
        }
        if(transform.position.y <= -4.8)
        {
            speed = .05f;
        }
        if(transform.position.y >= 4.8)
        {
            speed = -.05f;
        }
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
        else if(col.gameObject.tag == "Coin")
        {
            Destroy(col.gameObject);
            
        }
    }

    }


