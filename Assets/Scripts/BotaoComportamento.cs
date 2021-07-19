using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoComportamento : MonoBehaviour
{
    public GameObject gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    public void OnButtonPress()
    {
        GameManager gameManagerScript = gameManager.GetComponent<GameManager>();

        Debug.Log(gameManagerScript.respostaEtapa1Fase1);
    }
}