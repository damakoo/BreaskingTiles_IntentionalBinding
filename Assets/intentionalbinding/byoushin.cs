using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class byoushin : MonoBehaviour
{
    GameObject center;
    Vector3 center_position;
    // Start is called before the first frame update
    void Start()
    {
        center = GameObject.Find("tile/ban/center");
        center_position = center.transform.position;
        if (this.gameObject.name == "Cylinder1")
        {
            transform.RotateAround(center_position, transform.forward * (-1), 36);
        }else if (this.gameObject.name == "Cylinder2")
        {
            transform.RotateAround(center_position, transform.forward * (- 1), 72);
        }
        else if (this.gameObject.name == "Cylinder3")
        {
            transform.RotateAround(center_position, transform.forward * (-1), 108);
        }
        else if (this.gameObject.name == "Cylinder4")
        {
            transform.RotateAround(center_position, transform.forward * (-1), 144);
        }
        else if (this.gameObject.name == "Cylinder5")
        {
            transform.RotateAround(center_position, transform.forward * (-1), 180);
        }
        else if (this.gameObject.name == "Cylinder6")
        {
            transform.RotateAround(center_position, transform.forward * (-1), 216);
        }
        else if (this.gameObject.name == "Cylinder7")
        {
            transform.RotateAround(center_position, transform.forward * (-1), 252);
        }
        else if (this.gameObject.name == "Cylinder8")
        {
            transform.RotateAround(center_position, transform.forward * (-1), 288);
        }
        else if (this.gameObject.name == "Cylinder9")
        {
            transform.RotateAround(center_position, transform.forward * (-1), 324);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
