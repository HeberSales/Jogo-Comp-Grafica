using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    //[SerializeField] private string nomeDoLevelDeJogo;

    public void Jogar()
    {
        SceneManager.LoadScene("Game");
    }

    public void Sair()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
 
}
