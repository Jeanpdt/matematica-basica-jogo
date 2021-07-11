using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAbove : MonoBehaviour
{    public bool isInBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
   void Update(){
    if(isInBox){
    } else {
    }
}
    void OnTriggerStay(Collider other) {
        if(other.CompareTag("Player")) {
            isInBox = true;
        }
    }
    void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")) {
            isInBox = false;
        }
    }
}
