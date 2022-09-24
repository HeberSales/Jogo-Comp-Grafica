using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameWinScreen GameWinScreen;
    int maxPlatform = 0;

    public void GameWin()
    {
        GameWinScreen.Setup(maxPlatform);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.name.Equals("END"))
        {
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("END"))
        {
            GameWinScreen.Setup(maxPlatform);
        }
    }

}
