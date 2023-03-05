using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSoundController : MonoBehaviour
{
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    public void PlaySound() {
        if (counter < 3){
            counter ++;
        }

        else {
            this.gameObject.GetComponent<AudioSource>().Play();
        }
            
    }
}
