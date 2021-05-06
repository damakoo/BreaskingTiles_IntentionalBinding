using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatehari : MonoBehaviour
{
    GameObject center;
    Vector3 center_position;
    Quaternion center_rotation;
    public double start;
    // Start is called before the first frame update
    void Start()
    {
        center = GameObject.Find("tile/ban/center");
        center_position = center.transform.position;
        center_rotation = center.transform.rotation;
        start = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.RotateAround(center_position, (-1) * transform.forward, Time.fixedDeltaTime * 360);
        start += Time.fixedDeltaTime;
    }
}

