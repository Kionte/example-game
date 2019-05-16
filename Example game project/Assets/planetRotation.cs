using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetRotation : MonoBehaviour {

    public float planet = 0F;
	// Use this for initialization
	void Start () {
        Debug.Log("whats up");
	}
	
	// Update is called once per frame
	void Update () {
       this.transform.Rotate(0, planet*Time.deltaTime, 0, Space.Self);
   }
}
