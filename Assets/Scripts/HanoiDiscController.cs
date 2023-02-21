using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class HanoiDiscController : MonoBehaviour
{
    public GameObject disc;
    public bool hasDiscAbove = false;

    // If a disc has another disc above it, it should not be grabbable

    Quaternion defaultRotation;

    void Awake() {
        defaultRotation = transform.rotation;
    }


    void Update() {
       if (hasDiscAbove) {
        this.gameObject.GetComponent<Collider>().enabled = false;
       } else {
        this.gameObject.GetComponent<Collider>().enabled = true;     
       }
       if(this.gameObject.GetComponent<OVRGrabbable>().isGrabbed) {
        Debug.Log("GRABBBB");
       }
    }

    void LateUpdate() {
       transform.rotation =  defaultRotation;
    }
}
