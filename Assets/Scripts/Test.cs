using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
         Debug.Log("rrrrrrrrrr");
        if(other.gameObject.layer > this.gameObject.layer) {
            Debug.Log("KDJFLSDJJFKSLDF");
        }
    }
}
