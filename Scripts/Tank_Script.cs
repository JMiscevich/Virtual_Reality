using UnityEngine;
using System.Collections;

public class Tank_Script : MonoBehaviour
{

    public Light Plane_Spotlight;
    public Light Missile_Spotlight;
    public Light Tank_Spotlight;
    public int rotSpeed = 15;
    public GameObject Missile;
    public GameObject Plane;

    // Update is called once per frame
    void OnMouseOver()
    {
        
            Missile_Script MScript = Missile.GetComponent<Missile_Script>();
            Plane_Script PScript = Plane.GetComponent<Plane_Script>();
            rotSpeed = 90;
            Tank_Spotlight.enabled = true;
            MScript.rotSpeed = 0;
            PScript.rotSpeed = 0;        
    }

    void OnMouseExit()
    {
        Missile_Script MScript = Missile.GetComponent<Missile_Script>();
        Plane_Script PScript = Plane.GetComponent<Plane_Script>();
        Tank_Spotlight.enabled = false;
        rotSpeed = 15;
        MScript.rotSpeed = 15;
        PScript.rotSpeed = 15;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, rotSpeed, 0) * Time.deltaTime);
    }
}
