using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;
using UnityEngine.Events;

public class HanoiZoneController : MonoBehaviour
{
    public GameObject zoneBellow;
    public GameObject zoneAbove;
    public GameObject discAttached;

    public UnityEvent interactAction;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Disc") 
        {
            if(discAttached == null && bellowZoneCheck(other.gameObject))
            {
                this.gameObject.SetActive(false);
                this.gameObject.SetActive(true);
            }

            else
            {
                if (discAttached == null && (zoneBellow == null || zoneBellow.GetComponent<HanoiZoneController>().discAttached != null))
                {
                    placeDiscIntoZone(other.gameObject);
                }
            }

            if(discAttached == null && bellowZoneCheck(other.gameObject)) {
                interactAction.Invoke();
            }
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "Disc" && other.gameObject == discAttached) 
        {
            removeDiscFromZone();
        }
    }

    // Returns false if the zone bellow, has a disc who is bigger than the current one or there is no zone bellow
    private bool bellowZoneCheck(GameObject disc) 
    {
        return (zoneBellow != null && 
            disc.layer > zoneBellow.GetComponent<HanoiZoneController>().discAttached.layer);
    }

    private void placeDiscIntoZone(GameObject disc)
    {
        discAttached = disc;

        // Set the disc to return to this zone if not snapped elsewhere
        discAttached.GetComponent<SnapInteractor>()
            .InjectOptionalTimeOutInteractable(this.gameObject.GetComponent<SnapInteractable>());


        // Do not allow the zone bellow disc to be grabbed
        if (zoneBellow != null) {
            zoneBellow
            .GetComponent<HanoiZoneController>()
            .discAttached
            .GetComponent<HanoiDiscController>()
            .hasDiscAbove = true;
        }

        // Activate the zone above
        if (zoneAbove != null && discAttached == disc)
                zoneAbove.SetActive(true);
    }

    private void removeDiscFromZone() 
    {
        // Deactivate the zone above
        if (zoneAbove != null) 
            zoneAbove.SetActive(false);

        // Enable the disc in the zone bellow to be grabbed
        if (zoneBellow != null) 
        {
            zoneBellow
                .GetComponent<HanoiZoneController>()
                .discAttached
                .GetComponent<HanoiDiscController>()
                .hasDiscAbove = false;
        }
        discAttached = null;
    }
}
