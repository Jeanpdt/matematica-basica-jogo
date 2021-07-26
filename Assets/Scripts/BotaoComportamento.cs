using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BotaoComportamento : MonoBehaviour
{
    public GameObject gameManager;

    public GameObject objectCounter;


    void Start()
    {
        gameManager = GameObject.Find("GameManager");

        objectCounter = GameObject.Find("Counter");
    }

    public void OnButtonPress()
    {
        GameManager gameManagerScript = gameManager.GetComponent<GameManager>();

        BoxObjectCounter objectCounterScript = objectCounter.GetComponent<BoxObjectCounter>();

        if (objectCounterScript.qtdObjectsInBox == gameManagerScript.respostaEtapa1Fase1) {
            SceneManager.LoadScene("Leve0Etapa1");
        }
    }
}