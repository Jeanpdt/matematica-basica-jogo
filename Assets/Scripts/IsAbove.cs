using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsInBox : MonoBehaviour
{    
    public bool isInBox;

    public int qtdObjectsInBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update() {
    }
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Object")) {
            qtdObjectsInBox += 1;
        }
    }
    void OnTriggerExit(Collider other) {
        if(other.CompareTag("Object")) {
             qtdObjectsInBox -= 1;
        }
    }
}
