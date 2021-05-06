using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;


public class timecheck : MonoBehaviour
{
    private SteamVR_Action_Boolean actionToHaptic = SteamVR_Actions._default.InteractUI;
    double time;
    double ms;
    int s;
    int black;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        gameObject.GetComponent<Renderer>().material.color = new Color(255, 255, 255, 1f);
        black = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        //if (actionToHaptic.GetStateDown(SteamVR_Input_Sources.RightHand))
        {
            s = Random.Range(1, 10);
            ms = 100 * (double)s;
            black = 1;
            Debug.Log(ms);
        }

        if (black == 1)
        {
            time += Time.deltaTime;
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 1f);
            if (time > ms / (double)1000)
            {
                black = 0;
                time = 0;
                gameObject.GetComponent<Renderer>().material.color = new Color(255, 255, 255, 1f);
            }
         }


    }
}
