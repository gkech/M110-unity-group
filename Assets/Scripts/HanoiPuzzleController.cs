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

    public bool hasWon = false;

    private bool hasPlayed = false;

    private GameObject bottomZoneDiscAttached;
    private GameObject middleZoneDiscAttached;
    private GameObject topZoneDiscAttached;

    public GameObject EmissObj1;
    public GameObject EmissObj2;



    void Start()
    {
        EmissObj1.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        EmissObj2.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }
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
                hasWon = true;
                zones.SetActive(!zones.activeSelf);
                key.SetActive(!key.activeSelf);
                smoke.Play();
                hasPlayed = true;
                EmissObj1.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
                EmissObj2.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            }
            

        }

    }
}
