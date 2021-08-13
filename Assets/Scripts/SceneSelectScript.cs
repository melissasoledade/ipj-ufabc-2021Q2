// Script para os botões do menu principal
// Cada botão seleciona uma cena diferente do jogo, o script captura o click no botão

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour
{
    public void SelectScene(){
        switch(this.gameObject.name){
            case "Button":
            SceneManager.LoadScene("Scene2");
            break;

            case "Button2":
            SceneManager.LoadScene("Scene4");
            break;
        }
    }
}
