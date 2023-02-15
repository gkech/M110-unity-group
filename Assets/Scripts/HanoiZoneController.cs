using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class HanoiZoneController : MonoBehaviour
{
    public GameObject zoneBellow;
    public GameObject zoneAbove;
    public GameObject discAttached;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Disc") 
        {
            if (discCanBePlaced(other.gameObject)) {
                discAttached = other.gameObject;

                // Set the disc to return to this zone if not snapped elsewhere
                discAttached.GetComponent<SnapInteractor>()
                    .InjectOptionalTimeOutInteractable(this.gameObject.GetComponent<SnapInteractable>());

                if (zoneAbove != null)
                    zoneAbove.SetActive(true);

                if (zoneBellow != null)
                    zoneBellow.SetActive(false);
            }


            /*if(discAttached == null) 
            {
                discAttached = other.gameObject;
                if (zoneBellow != null && 
                    discAttached.layer > zoneBellow.GetComponent<HanoiZoneController>().discAttached.layer)
                {
                    Debug.Log("EEEEEEE");
                    this.gameObject.SetActive(false);
                    return;
                }

                if (zoneAbove != null)
                    zoneAbove.SetActive(true);

                if (zoneBellow != null)
                    zoneBellow.SetActive(false);

                // Set the disc to return to this zone if not snapped elsewhere
                discAttached.GetComponent<SnapInteractor>()
                    .InjectOptionalTimeOutInteractable(this.gameObject.GetComponent<SnapInteractable>());

                discAttached.GetComponent<PreviousZone>().previousSnapZone 
                = this.gameObject.transform;
            }*/
        }
    }

        private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == "Disc") {
            if (zoneAbove != null)
                zoneAbove.SetActive(false);

            if (zoneBellow != null)
                zoneBellow.SetActive(true);

            discAttached = null;
        }
    }

    /* 
     * A disc can be placed if there is no zone bellow or if the disc on the zone bellow 
     * is bigger than the current disc
     */
    private bool discCanBePlaced(GameObject disc) 
    {
        if (discAttached == null) 
        {
            if (zoneBellow != null && 
            disc.layer > zoneBellow.GetComponent<HanoiZoneController>().discAttached.layer)
            {
                return false;
            }
            return true;
        }
        return false;
    }
}
