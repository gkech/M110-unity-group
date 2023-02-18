using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class HanoiPuzzleController : MonoBehaviour
{
    public GameObject bottomZone;
    public GameObject middleZone;
    public GameObject topZone;

    private GameObject bottomZoneDiscAttached;
    private GameObject middleZoneDiscAttached;
    private GameObject topZoneDiscAttached;


    // Update is called once per frame
    void Update()
    {   
        bottomZoneDiscAttached = bottomZone.GetComponent<HanoiZoneController>().discAttached;
        middleZoneDiscAttached = middleZone.GetComponent<HanoiZoneController>().discAttached;
        topZoneDiscAttached = topZone.GetComponent<HanoiZoneController>().discAttached;

        if (bottomZoneDiscAttached != null &&
            middleZoneDiscAttached != null &&
            topZoneDiscAttached != null &&
            bottomZoneDiscAttached.name == "DiscBig" && 
            middleZoneDiscAttached.name == "DiscMedium" && 
            topZoneDiscAttached.name == "DiscSmall"
        )
            Debug.Log("WIN");
    }
}
