using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class HanoiPuzzleController : MonoBehaviour
{
    public GameObject bottomZone;
    public GameObject middleZone;
    public GameObject topZone;
    public GameObject key;
    public ParticleSystem smoke;

    public GameObject zones;

    private bool hasPlayed = false;

    private GameObject bottomZoneDiscAttached;
    private GameObject middleZoneDiscAttached;
    private GameObject topZoneDiscAttached;


    // Update is called once per frame
    void Update()
    {   
        bottomZoneDiscAttached = bottomZone.GetComponent<HanoiZoneController>().discAttached;
        middleZoneDiscAttached = middleZone.GetComponent<HanoiZoneController>().discAttached;
        topZoneDiscAttached = topZone.GetComponent<HanoiZoneController>().discAttached;

        
        
        // if (bottomZoneDiscAttached != null &&
        //     middleZoneDiscAttached != null &&
        //     topZoneDiscAttached != null &&
        //     bottomZoneDiscAttached.name == "DiscBig" && 
        //     middleZoneDiscAttached.name == "DiscMedium" && 
        //     topZoneDiscAttached.name == "DiscSmall"
        // )
        if( bottomZoneDiscAttached != null && bottomZoneDiscAttached.name == "DiscSmall" )
        {
            Debug.Log("WIN");
            
            if(  !hasPlayed )
            {   
                zones.SetActive(!zones.activeSelf);
                key.SetActive(!key.activeSelf);
                smoke.Play();
                hasPlayed = true;
            }
            

        }

    }
}
