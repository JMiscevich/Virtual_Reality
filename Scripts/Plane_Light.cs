using UnityEngine;
using System.Collections;

public class Plane_Light : MonoBehaviour {

    public Light Plane_Spotlight;

    // Use this for initialization
    void Start()
    {
        Plane_Spotlight.enabled = false;
    }
}
