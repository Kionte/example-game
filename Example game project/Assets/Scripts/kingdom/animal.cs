using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animal : MonoBehaviour {

    private bool alive;

    public animal()
    {
        alive = true;
    }

    public bool Alive
    {
        get { return alive; }
        set { alive = value; }
    }
 


}
