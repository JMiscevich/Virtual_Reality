using UnityEngine;
using System.Collections;

public class Tank_Light : MonoBehaviour {

    public Light Tank_Spotlight;

	// Use this for initialization
	void Start () {
        Tank_Spotlight.enabled = false;
    }

}
