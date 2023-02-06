using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToLocation : MonoBehaviour
{
    private bool grabbed;
    private bool insideSnapZone;
    public bool Snapped;
    public GameObject objectToSnap;
    public GameObject SnapRotationReference;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == objectToSnap.name) {
            insideSnapZone = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name == objectToSnap.name) {
            insideSnapZone = false;
        }
    }

    void SnapObject() {
        if (!grabbed && insideSnapZone) {
            objectToSnap.gameObject.transform.position = transform.position;
            objectToSnap.gameObject.transform.rotation = SnapRotationReference.transform.rotation;
            Snapped = true;
        }
    }

    private void Update() {
        grabbed = objectToSnap.GetComponent<OVRGrabbable>().isGrabbed;
        SnapObject();
    }
}
