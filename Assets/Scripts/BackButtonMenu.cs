// Script criado para o botão que está dentro das cenas do jogo
// Ao clicar, volta para o menu principal

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonMenu : MonoBehaviour
{
  public void BackToMenu(){
      SceneManager.LoadScene("menuScene");
  }
}
