// Ativa o trigger para finalizar uma volta na pista

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject LapComplete; 
    public GameObject HalfLap;

    void OnTriggerEnter(){        
        LapComplete.SetActive(true); //ativar gatilho na pista do jogo
        HalfLap.SetActive(false); 
    }
    
}
