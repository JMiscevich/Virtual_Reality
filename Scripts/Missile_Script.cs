using UnityEngine;
using System.Collections;

public class Missile_Script : MonoBehaviour
{

    public Light Plane_Spotlight;
    public Light Missile_Spotlight;
    public Light Tank_Spotlight;
    public int rotSpeed = 15;
    public GameObject Plane;
    public GameObject Tank;


    // Update is called once per frame
    void OnMouseOver()
    {
        Plane_Script PScript = Plane.GetComponent<Plane_Script>();
        Tank_Script TScript = Tank.GetComponent<Tank_Script>();
        rotSpeed = 90;
        Missile_Spotlight.enabled = true;
        PScript.rotSpeed = 0;
        TScript.rotSpeed = 0;
    }

    void OnMouseExit() {
        Plane_Script PScript = Plane.GetComponent<Plane_Script>();
        Tank_Script TScript = Tank.GetComponent<Tank_Script>();
        Missile_Spotlight.enabled = false;
        PScript.rotSpeed = 15;
        TScript.rotSpeed = 15;
        rotSpeed = 15;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, rotSpeed, 0) * Time.deltaTime);
    }
}

