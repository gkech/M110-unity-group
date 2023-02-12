using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class HanoiZoneController : MonoBehaviour
{
    public GameObject zoneBellow;
    public GameObject zoneAbove;
    public GameObject discAttached;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Disc") {
            if (zoneAbove != null)
                zoneAbove.SetActive(true);

            if (zoneBellow != null)
                zoneBellow.SetActive(false);

            discAttached = other.gameObject;
            discAttached.GetComponent<SnapInteractor>().InjectOptionalTimeOutInteractable(this.gameObject.GetComponent<SnapInteractable>());
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
}
