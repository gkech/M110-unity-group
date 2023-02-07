using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
    public GameObject SnapLocation;
        public GameObject snapObject;
        public bool isSnapped;
        private bool objectSnapped;
        private bool grabbed;

    // Update is called once per frame
    void Update()
    {

        grabbed = GetComponent<OVRGrabbable>().isGrabbed;
        objectSnapped = SnapLocation.GetComponent<SnapToLocation>().Snapped;

        if ( objectSnapped == true) {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.SetParent(snapObject.transform);
            isSnapped = true;
        }

        if (objectSnapped == false && grabbed ) {
            GetComponent<Rigidbody>().isKinematic =false;
        }

    }
}
