using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectTransform : MonoBehaviour {

    public float rotate = 0F;
    public float position = 0F;
	// Use this for initialization
	void Start () {
        Debug.Log("whats up");
	}
	
	// Update is called once per frame
	void Update ()
    {
        objectRotate(rotate);
        objectPosition(position);
    }
    void objectRotate(float rotate)
    {
        this.transform.Rotate(0, rotate * Time.deltaTime, 0, Space.Self);
    }
    void objectPosition(float position)
    { }
}
