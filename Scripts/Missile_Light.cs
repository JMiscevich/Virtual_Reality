using UnityEngine;
using System.Collections;

public class Missile_Light : MonoBehaviour {


    public Light Missile_Spotlight;

    // Use this for initialization
    void Start()
    {
        Missile_Spotlight.enabled = false;
    }
}
