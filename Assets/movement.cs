using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float movespeed = 10;
    public float turnspeed = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CheckInput();
	}

    void CheckInput()
    {
        if (Input.GetButton("Vertical") == true)
        {
            transform.Translate(new Vector3(0,0,Input.GetAxisRaw("Vertical")* movespeed * Time.deltaTime));
        }
        if(Input.GetButton("Horizontal") == true)
        {
            transform.Rotate(new Vector3(0, Input.GetAxisRaw("Horizontal"), 0 * turnspeed * Time.deltaTime));
        }
    }

}

