using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;

public class breaktile : MonoBehaviour
{
    private SteamVR_Action_Boolean actionToHaptic = SteamVR_Actions._default.InteractUI;
    
    GameObject brokentile_child1;
    GameObject brokentile_child2;
    GameObject brokentile_child3;
    GameObject brokentile_child4;
    GameObject brokentile_child5;
    GameObject brokentile_child6;
    GameObject tile1;
    GameObject tile2;
    GameObject tile3;
    GameObject tile4;
    GameObject tile5;
    GameObject tile6;
    tobreak Tobreak;

    // Start is called before the first frame update
    void Start()
    {
        brokentile_child1 = GameObject.Find("tile/brokentile_child(1)");
        if (brokentile_child1 == null)
        {
            Debug.Log("false");
            return;
        }
        brokentile_child1.gameObject.SetActive(false);
        brokentile_child2 = GameObject.Find("tile/brokentile_child(2)");
        brokentile_child2.gameObject.SetActive(false);
        brokentile_child3 = GameObject.Find("tile/brokentile_child(3)");
        brokentile_child3.gameObject.SetActive(false);
        brokentile_child4 = GameObject.Find("tile/brokentile_child(4)");
        brokentile_child4.gameObject.SetActive(false);
        brokentile_child5 = GameObject.Find("tile/brokentile_child(5)");
        brokentile_child5.gameObject.SetActive(false);
        brokentile_child6 = GameObject.Find("tile/brokentile_child(6)");
        brokentile_child6.gameObject.SetActive(false);
        tile1 = GameObject.Find("tile/tile(1)/tile");
        tile2 = GameObject.Find("tile/tile(2)/tile");
        tile3 = GameObject.Find("tile/tile(3)/tile");
        tile4 = GameObject.Find("tile/tile(4)/tile");
        tile5 = GameObject.Find("tile/tile(5)/tile");
        tile6 = GameObject.Find("tile/tile(6)/tile");
        Tobreak = GameObject.Find("tile/tile(1)").gameObject.GetComponent<tobreak>();

        //Destroy(brokentile_child);
    }

    // Update is called once per frame
    void Update()
    {
        if (/*Input.GetKeyDown(KeyCode.Space) || */Tobreak.brk == 1)
        {
            brokentile_child1.gameObject.SetActive(true);
            brokentile_child2.gameObject.SetActive(true);
            brokentile_child3.gameObject.SetActive(true);
            brokentile_child4.gameObject.SetActive(true);
            brokentile_child5.gameObject.SetActive(true);
            brokentile_child6.gameObject.SetActive(true);
            tile1.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
            tile2.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
            tile3.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
            tile4.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
            tile5.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);
            tile6.GetComponent<Renderer>().material.color = new Color(0, 0, 0, 0);

            //brokentile_child = Instantiate(brokentile_child);
        }
        if (Input.GetKeyDown(KeyCode.Return) || actionToHaptic.GetStateDown(SteamVR_Input_Sources.LeftHand))
        {
            //Destroy(brokentile_child.gameObject);
            //brokentile_child.gameObject.SetActive(false);
            SceneManager.LoadScene("trial");
            Tobreak.brk = 0;
        }
    }
}
