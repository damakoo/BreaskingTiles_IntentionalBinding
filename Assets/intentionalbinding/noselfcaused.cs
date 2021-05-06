using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class noselfcaused : MonoBehaviour
{
    private SteamVR_Action_Boolean actionToHaptic = SteamVR_Actions._default.InteractUI;

    GameObject tile;
    GameObject controller;    
    Vector3 tile_pos;
    Vector3 mytransform;
    Vector3 nowpos;
    private int start = 0;
    private int i = 0;
    int b = 60;
    private int c = 50;
    int starting;
    // Start is called before the first frame update
    void Start()
    {
        tile = GameObject.Find("tile/tile_pos");
        tile_pos = tile.transform.position;
        controller = GameObject.Find("[CameraRig]/vr_glove_right_model_slim");
        starting = Random.Range(30, 60) * 10;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (actionToHaptic.GetStateDown(SteamVR_Input_Sources.RightHand))
        {
            start = 1;
        }*/
        start += 1;
        if (start > starting)
        {
            mytransform = this.transform.position; //controller.transform.position;
            if (i < b)
            {
                nowpos = ((float)i * (-1) * tile_pos + (float)(70 * b + i) * mytransform) / (float)b / (float)70;
               // nowpos = ((float)i * tile_pos + (float)(c - i) * nowpos) / (float)c;
                i += 1;
            }
            else if (i <  b + c)
            {
                nowpos = ((float)(i - b) * tile_pos + (float)(c - i + b) * mytransform) / (float)c;
                i += 1;
            }else
            {
                nowpos = tile_pos;
            }
            this.gameObject.transform.position = nowpos;

        }
    }
}
