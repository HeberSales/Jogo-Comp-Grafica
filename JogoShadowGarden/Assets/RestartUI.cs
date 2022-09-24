using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartUI : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "StartGame";
   
    public void RestartButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
