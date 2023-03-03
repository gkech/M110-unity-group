using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PowerGeneratorGlow : MonoBehaviour
{
    HanoiPuzzleController hanoiGoalStack;

    public GameObject goal ;

    public bool isPlayerInRange = false;
    public bool soundPlayed = false;
    public GameObject audio ;
    AudioSource sound;

    
    void Awake()
    {
        hanoiGoalStack = goal.GetComponent<HanoiPuzzleController>();
    }
    void Start()
    {
        isPlayerInRange = false;
    }

    void Update()
    {
        
        if( isPlayerInRange && hanoiGoalStack.hasWon && !soundPlayed)
        {
            Debug.Log("correeeeeeect sofia");
            sound= audio.GetComponent<AudioSource> ();
            sound.Play();
            soundPlayed = true;
        }
        
        
    }

     private void OnTriggerEnter(Collider other){
         
        if(other.gameObject.layer == 7)
        {
            isPlayerInRange =true;
            print("in zone key collider");

     }

            
        
    }

    private void OnTriggerExit(Collider other){
          
        if( other.gameObject.layer == 7)
        {
            isPlayerInRange =false;
     }
            
        
    }
}
