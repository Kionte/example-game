using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetRotation : MonoBehaviour {

    public GameObject planet;// = new GameObject();
    public float num = 0;
	// Use this for initialization
	void Start () {
        Debug.Log("whats up");
	}
	
	// Update is called once per frame
	void Update () {
        planet.transform.Rotate(0, 180*Time.deltaTime, 0, Space.Self);
   }
}
