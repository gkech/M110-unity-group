using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class HanoiPuzzleController : MonoBehaviour
{
    public List<GameObject> discs;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log( discs[0].GetComponent<SnapInteractor>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
