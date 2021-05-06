using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class tobreak : MonoBehaviour
{
    [SerializeField] AudioClip[] clips;
    [SerializeField] bool randomizePitch = true;
    [SerializeField] float pitchRange = 0.1f;

    GameObject hari;
    double harirotz;
    protected AudioSource source;
    int s;
    double ms;
    double time = 0;
    int touch = 0;
    rotatehari Rotatehari;
    double starttime;
    //private SteamVR_Action_Vibration haptic = SteamVR_Actions._default.Haptic;
    public int brk = 0;
    // Start is called before the first frame update
    void Start()
    {
        hari = GameObject.Find("tile/ban/hari");
        Rotatehari = hari.gameObject.GetComponent<rotatehari>();
        source = GetComponents<AudioSource>()[0];
    }
    //100ms, 200ms，300ms，400ms，500ms，700ms，1000ms，
    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (touch == 1 && brk == 0)
        {
            time += Time.fixedDeltaTime;
            if (time > ms / (double)1000)
            {
                source.Play();
                brk = 1;
                touch = 0;
                starttime = (Rotatehari.start % 1) * 10d;
                Debug.Log("start = " + starttime);
            }
        }

        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            starttime = (Rotatehari.start % 1) * 10d;
            Debug.Log("start = " + starttime);
            source.Play();
            brk = 1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        if ((other.gameObject.name == "Sphere" && touch == 0))
        {
            starttime = (Rotatehari.start % 1) * 10d;   
            Debug.Log("start = " + starttime );
            touch = 1;
            s = Random.Range(8,9);
            /*if (s == 9)
            {
                s = 1;
            }else if (s == 10)
            {
                s = 2;
            }
            else if (s == 11)
            {
                s = 3;
            }
            else if (s == 12)
            {
                s = 4;
            }*/
            ms = 100 * (double)s;
            Debug.Log("interbal = " + ms);
            //haptic.Execute(0, 0.1f, 60, 1, SteamVR_Input_Sources.RightHand);
        }
        
    }
}
