    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyZoneController : MonoBehaviour
{

    public Animator portalAnimator;

    public GameObject portalGlow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "key") 
        {
            portalGlow.SetActive(true);
            //portalAnimator.Play();
        }
    }
}
