using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausarMenu : MonoBehaviour
{
    public Transform pauseMenu;    

    void Start()
    {

    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.gameObject.activeSelf)
            {
                pauseMenu.gameObject.SetActive(false);
                Time.timeScale = 0;
            }
            else
            {
                pauseMenu.gameObject.SetActive(true);
                Time.timeScale = 1;
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Novo Menu");
    }

}
