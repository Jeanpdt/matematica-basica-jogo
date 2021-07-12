using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoComportamento : MonoBehaviour
{
    public GameObject recipiente;

    void Start()
    {
        recipiente = GameObject.Find("Counter");
    }

    public void OnButtonPress()
    {
        BoxObjectCounter boxObjectCounter = recipiente.GetComponent<BoxObjectCounter>();

        Debug.Log(boxObjectCounter.qtdObjectsInBox);
    }
}
